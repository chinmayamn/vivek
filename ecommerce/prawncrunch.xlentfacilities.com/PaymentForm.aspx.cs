using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using ThePaymentGateway.PaymentSystem;
using ThePaymentGateway.Common;

namespace MyCompanyName
{
    public partial class PaymentForm : System.Web.UI.Page
    {
        private enum FORM_MODE
        {
            PAYMENT_FORM,
            THREE_D_SECURE,
            RESULTS
        }

        private FORM_MODE m_fmFormMode = FORM_MODE.PAYMENT_FORM;
        protected internal string m_szPaREQ;
        protected internal string m_szTermURL;
        protected internal string m_szACSURL;
        protected internal string m_szCrossReference;

        protected void Page_Load(object sender, EventArgs e)
        {
            string orderid = (Session["orderid"].ToString());
            string amount = Session["amount"].ToString();

            hfOrderID.Value = orderid;
            hfAmount.Value = Convert.ToString(Math.Round(Convert.ToDouble(amount)));
            Literal1.Text = hfAmount.Value;
          //  Label1.Text = Session["amount"].ToString();
            if (!IsPostBack)
            {
        
                PopulateFormItems();
            }

            // need to work out whether to try the 3d secure authentication
            if (Request.Form["PaRES"] != null &&
                Request.Form["CrossReference"] != null)
            {
                PerformThreeDSecureAuthentication(Request.Form["PaRES"], Request.Form["CrossReference"]);
            }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            // need to work out what mode to put the form into
            switch (m_fmFormMode)
            {
                case FORM_MODE.PAYMENT_FORM:
                    PaymentFormMultiView.SetActiveView(PaymentFormView);
                    break;
                case FORM_MODE.THREE_D_SECURE:
                    PaymentFormMultiView.SetActiveView(ThreeDSecureView);

                    ACSFrame.Attributes["src"] = Global.SiteSecureBaseURL + "Loading.htm";
                    BodyTag.Attributes["onload"] += "document.ACSForm.submit();";
                    break;
                case FORM_MODE.RESULTS:
                    PaymentFormMultiView.SetActiveView(ResultsView);
                    break;
                default:
                    throw new Exception("Invalid form mode: " + m_fmFormMode.ToString());
            }

            hfFormMode.Value = m_fmFormMode.ToString();
        }

        private void PerformThreeDSecureAuthentication(string szPaRES, string szCrossReference)
        {
            string szMessage = null;
            bool boTransactionSuccessful = false;
            StringBuilder sbString;
            int nCount = 0;
            ThreeDSecureAuthentication tdsaThreeDSecureAuthentication;
            RequestGatewayEntryPointList lrgepRequestGatewayEntryPoints;
            GatewayOutput goGatewayOutput;
            TransactionOutputMessage tomTransactionOutputMessage;
            string szPreviousTransactionMessage = null;
            bool boDuplicateTransaction = false;

            lrgepRequestGatewayEntryPoints = new RequestGatewayEntryPointList();
            // you need to put the correct gateway entry point urls in here
            // contact support to get the correct urls

            // The actual values to use for the entry points can be established in a number of ways
            // 1) By periodically issuing a call to GetGatewayEntryPoints
            // 2) By storing the values for the entry points returned with each transaction
            // 3) Speculatively firing transactions at https://gw1.xxx followed by gw2, gw3, gw4....
            // The lower the metric (2nd parameter) means that entry point will be attempted first,
            // EXCEPT if it is -1 - in this case that entry point will be skipped
            // NOTE: You do NOT have to add the entry points in any particular order - the list is sorted
            // by metric value before the transaction sumbitting process begins
            // The 3rd parameter is a retry attempt, so it is possible to try that entry point that number of times
            // before failing over onto the next entry point in the list
            lrgepRequestGatewayEntryPoints.Add(new RequestGatewayEntryPoint("https://gw1." + Global.PaymentProcessorFullDomain, 100, 2));
            lrgepRequestGatewayEntryPoints.Add(new RequestGatewayEntryPoint("https://gw2." + Global.PaymentProcessorFullDomain, 200, 2));
            lrgepRequestGatewayEntryPoints.Add(new RequestGatewayEntryPoint("https://gw3." + Global.PaymentProcessorFullDomain, 300, 2));

            tdsaThreeDSecureAuthentication = new ThreeDSecureAuthentication(
                lrgepRequestGatewayEntryPoints,
                new MerchantDetails(Global.MerchantID, Global.Password),
                new ThreeDSecureInputData(szCrossReference, szPaRES),
                null);

            // send the SOAP request
            if (!tdsaThreeDSecureAuthentication.ProcessTransaction(out goGatewayOutput, out tomTransactionOutputMessage))
            {
                szMessage = "Couldn't communicate with payment gateway";
                boTransactionSuccessful = true;
            }
            else
            {
                switch (goGatewayOutput.StatusCode)
                {
                    case 0:
                        // status code of 0 - means transaction successful 
                        boTransactionSuccessful = true;
                        m_fmFormMode = FORM_MODE.RESULTS;
                        szMessage = goGatewayOutput.Message;
                        break;
                    case 5:
                        // status code of 5 - means transaction declined 
                        boTransactionSuccessful = false;
                        m_fmFormMode = FORM_MODE.RESULTS;
                        szMessage = goGatewayOutput.Message;
                        break;
                    case 20:
                        // status code of 20 - means duplicate transaction 
                        m_fmFormMode = FORM_MODE.RESULTS;
                        szMessage = goGatewayOutput.Message;
                        if (goGatewayOutput.PreviousTransactionResult.StatusCode.Value == 0)
                        {
                            boTransactionSuccessful = true;
                        }
                        else
                        {
                            boTransactionSuccessful = false;
                        }
                        szPreviousTransactionMessage = goGatewayOutput.PreviousTransactionResult.Message;
                        boDuplicateTransaction = true;
                        break;
                    case 30:
                        // status code of 30 - means an error occurred 
                        boTransactionSuccessful = false;
                        m_fmFormMode = FORM_MODE.RESULTS;

                        sbString = new StringBuilder();

                        // get any additional messages
                        if (goGatewayOutput.ErrorMessages.Count > 0)
                        {
                            sbString.Append("<br /><ul>");

                            for (nCount = 0; nCount < goGatewayOutput.ErrorMessages.Count; nCount++)
                            {
                                sbString.AppendFormat("<li>{0}</li>", goGatewayOutput.ErrorMessages[nCount]);
                            }
                            sbString.Append("</ul>");
                        }

                        szMessage = goGatewayOutput.Message + sbString.ToString();
                        break;
                    default:
                        // unhandled status code  
                        boTransactionSuccessful = false;
                        m_fmFormMode = FORM_MODE.RESULTS;
                        szMessage = goGatewayOutput.Message;
                        break;
                }
            }

            pnTransactionResultsPanel.Visible = true;
            pnMessagePanel.Visible = false;

            if (!boTransactionSuccessful)
            {
                pnTransactionResultsPanel.CssClass = "ErrorMessage";
            }
            else
            {
                pnTransactionResultsPanel.CssClass = "SuccessMessage";
            }

            lbGatewayResponse.Text = szMessage;

            // sort out the duplicate transaction reporting
            if (boDuplicateTransaction)
            {
                pnDuplicateTransactionPanel.Visible = true;
                lbPreviousTransactionMessage.Text = szPreviousTransactionMessage;
            }

            // the process another link
            hlProcessAnother.NavigateUrl = Global.SiteSecureBaseURL + "PaymentForm.aspx";
        }

        private void PopulateFormItems()
        {
            string szWorkingValue;
            string szWorkingDisplayValue;
            int nCount = 0;
            int nCurrentYear;
            ListItem liListItem;
            bool boHitFirstZeroPriorityCountry = false;

            tbAddress1.Text = "";
            tbAddress2.Text = "";
            tbAddress3.Text = "";
            tbAddress4.Text = "";
            tbCity.Text = "";
            tbState.Text = "";
            tbPostCode.Text = "";
            tbCardName.Text = "";
            tbCardNumber.Text = "";
            tbIssueNumber.Text = "";
            tbCV2.Text = "";
            lbMessageLabel.Text = "";
            pnMessagePanel.Visible = false;

            liListItem = new ListItem("", "-1");
            ddCountries.Items.Add(liListItem);

            // populate the country drop down
            for (nCount = 0; nCount < Global.ISOCountryData.Count; nCount++)
            {
                if (nCount > 0 &&
                    !boHitFirstZeroPriorityCountry &&
                    Global.ISOCountryData[nCount].ListPriority == 0)
                {
                    boHitFirstZeroPriorityCountry = true;
                    liListItem = new ListItem("---------------------", "-1");
                    ddCountries.Items.Add(liListItem);
                }
                liListItem = new ListItem(Global.ISOCountryData[nCount].CountryName, Global.ISOCountryData[nCount].ISOCode.ToString());

                ddCountries.Items.Add(liListItem);
            }

            nCurrentYear = DateTime.Now.Year;

            ddExpiryDateYear.Items.Add("");
            ddExpiryDateMonth.Items.Add("");

            ddStartDateYear.Items.Add("");
            ddStartDateMonth.Items.Add("");

            for (nCount = 0; nCount < 10; nCount++)
            {
                // expiry date - start with this year & add 10
                szWorkingDisplayValue = System.Convert.ToString(nCurrentYear + nCount);
                szWorkingValue = szWorkingDisplayValue.Substring(2);
                liListItem = new ListItem(szWorkingDisplayValue, szWorkingValue);
                ddExpiryDateYear.Items.Add(liListItem);

                // start date - start with this year & minus 10
                szWorkingDisplayValue = System.Convert.ToString(nCurrentYear - nCount);
                szWorkingValue = szWorkingDisplayValue.Substring(2);
                liListItem = new ListItem(szWorkingDisplayValue, szWorkingValue);
                ddStartDateYear.Items.Add(liListItem);
            }

            for (nCount = 1; nCount <= 12; nCount++)
            {
                szWorkingValue = System.Convert.ToString(nCount);
                szWorkingDisplayValue = SharedFunctions.ForwardPaddedNumberString(nCount, 2, '0');
                liListItem = new ListItem(szWorkingDisplayValue, szWorkingValue);
                ddExpiryDateMonth.Items.Add(liListItem);

                liListItem = new ListItem(szWorkingDisplayValue, szWorkingValue);
                ddStartDateMonth.Items.Add(liListItem);
            }
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            string szMessage = null;
            bool boTransactionSuccessful = false;
            StringBuilder sbString;
            int nCount = 0;
            int nTemp;
            CardDetailsTransaction cdtCardDetailsTransaction;
            RequestGatewayEntryPointList lrgepRequestGatewayEntryPoints;
            GatewayOutput goGatewayOutput;
            TransactionOutputMessage tomTransactionOutputMessage;
            TransactionControl tcTransactionControl;
            CardDetails cdCardDetails;
            CreditCardDate ccdExpiryDate = null;
            CreditCardDate ccdStartDate = null;
            CustomerDetails cdCustomerDetails = null;
            NullableInt nCountryCode = null;
            NullableInt nExpiryDateMonth = null;
            NullableInt nExpiryDateYear = null;
            NullableInt nStartDateMonth = null;
            NullableInt nStartDateYear = null;
            string szPreviousTransactionMessage = null;
            bool boDuplicateTransaction = false;

            lrgepRequestGatewayEntryPoints = new RequestGatewayEntryPointList();
	        // you need to put the correct gateway entry point urls in here
	        // contact support to get the correct urls

            // The actual values to use for the entry points can be established in a number of ways
            // 1) By periodically issuing a call to GetGatewayEntryPoints
            // 2) By storing the values for the entry points returned with each transaction
            // 3) Speculatively firing transactions at https://gw1.xxx followed by gw2, gw3, gw4....
	        // The lower the metric (2nd parameter) means that entry point will be attempted first,
	        // EXCEPT if it is -1 - in this case that entry point will be skipped
	        // NOTE: You do NOT have to add the entry points in any particular order - the list is sorted
	        // by metric value before the transaction sumbitting process begins
	        // The 3rd parameter is a retry attempt, so it is possible to try that entry point that number of times
	        // before failing over onto the next entry point in the list
            lrgepRequestGatewayEntryPoints.Add(new RequestGatewayEntryPoint("https://gw1." + Global.PaymentProcessorFullDomain, 100, 2));
            lrgepRequestGatewayEntryPoints.Add(new RequestGatewayEntryPoint("https://gw2." + Global.PaymentProcessorFullDomain, 200, 2));
            lrgepRequestGatewayEntryPoints.Add(new RequestGatewayEntryPoint("https://gw3." + Global.PaymentProcessorFullDomain, 300, 2));

            tcTransactionControl = new TransactionControl(new NullableBool(true),
                new NullableBool(true),
                new NullableBool(true),
                new NullableBool(true),
                new NullableInt(60),
                null,
                null,
                null,
                null,
                null,
                null);

            if (!String.IsNullOrEmpty(ddExpiryDateMonth.SelectedValue))
            {
                nExpiryDateMonth = new NullableInt(System.Convert.ToInt32(ddExpiryDateMonth.SelectedValue));
            }
            if (!String.IsNullOrEmpty(ddExpiryDateYear.SelectedValue))
            {
                nExpiryDateYear = new NullableInt(System.Convert.ToInt32(ddExpiryDateYear.SelectedValue));
            }
            ccdExpiryDate = new CreditCardDate(nExpiryDateMonth, nExpiryDateYear);

            if (!String.IsNullOrEmpty(ddStartDateMonth.SelectedValue))
            {
                nStartDateMonth = new NullableInt(System.Convert.ToInt32(ddStartDateMonth.SelectedValue));
            }
            if (!String.IsNullOrEmpty(ddStartDateYear.SelectedValue))
            {
                nStartDateYear = new NullableInt(System.Convert.ToInt32(ddStartDateYear.SelectedValue));
            }
            ccdStartDate = new CreditCardDate(nStartDateMonth, nStartDateYear);

            cdCardDetails = new CardDetails(tbCardName.Text, tbCardNumber.Text, ccdExpiryDate, ccdStartDate, tbIssueNumber.Text, tbCV2.Text);

            if (!String.IsNullOrEmpty(ddCountries.SelectedValue))
            {
                nTemp = System.Convert.ToInt32(ddCountries.SelectedValue);
                if (nTemp != -1)
                {
                    nCountryCode = new NullableInt(nTemp);
                }
            }
            cdCustomerDetails = new CustomerDetails(new AddressDetails(tbAddress1.Text, tbAddress2.Text, tbAddress3.Text, tbAddress4.Text, tbCity.Text, tbState.Text, tbPostCode.Text, nCountryCode),
                "test@test.com", "123456789", Request.UserHostAddress);

            cdtCardDetailsTransaction = new CardDetailsTransaction(lrgepRequestGatewayEntryPoints,
                new MerchantDetails(Global.MerchantID, Global.Password),
                new TransactionDetails(TRANSACTION_TYPE.SALE, new NullableInt(System.Convert.ToInt32(hfAmount.Value)), new NullableInt(System.Convert.ToInt32(hfCurrencyISOCode.Value)), hfOrderID.Value, hfOrderDescription.Value, tcTransactionControl, new ThreeDSecureBrowserDetails(new NullableInt(0), "*/*", Request.UserAgent)),
                cdCardDetails,
                cdCustomerDetails,
                null);

            // send the SOAP request
            if (!cdtCardDetailsTransaction.ProcessTransaction(out goGatewayOutput, out tomTransactionOutputMessage))
            {
                szMessage = "Couldn't communicate with payment gateway";
                boTransactionSuccessful = false;
            }
            else
            {
                switch (goGatewayOutput.StatusCode)
                {
                    case 0:
				        // status code of 0 - means transaction successful 
                        boTransactionSuccessful = true;
                        m_fmFormMode = FORM_MODE.RESULTS;
                        szMessage = goGatewayOutput.Message;
                        break;
                    case 3:
				        // status code of 3 - means 3D Secure authentication required 
                        m_fmFormMode = FORM_MODE.THREE_D_SECURE;
                        m_szTermURL = Global.SiteSecureBaseURL + "ThreeDSecureLandingPage.aspx";
                        m_szPaREQ = tomTransactionOutputMessage.ThreeDSecureOutputData.PaREQ;
                        m_szACSURL = tomTransactionOutputMessage.ThreeDSecureOutputData.ACSURL;
                        m_szCrossReference = tomTransactionOutputMessage.CrossReference;
                        break;
                    case 5:
				        // status code of 5 - means transaction declined 
                        boTransactionSuccessful = false;
                        m_fmFormMode = FORM_MODE.RESULTS;
                        szMessage = goGatewayOutput.Message;
                        break;
                    case 20:
				        // status code of 20 - means duplicate transaction 
				        m_fmFormMode = FORM_MODE.RESULTS;
				        szMessage = goGatewayOutput.Message;
				        if (goGatewayOutput.PreviousTransactionResult.StatusCode.Value == 0)
                        {
					        boTransactionSuccessful = true;
				        }
                        else
                        {
					        boTransactionSuccessful = false;
			   	        }
				        szPreviousTransactionMessage = goGatewayOutput.PreviousTransactionResult.Message;
                        boDuplicateTransaction = true;
                        break;
                    case 30:
				        // status code of 30 - means an error occurred 
                        boTransactionSuccessful = false;
                        m_fmFormMode = FORM_MODE.PAYMENT_FORM;

                        sbString = new StringBuilder();

                        // get any additional messages
                        if (goGatewayOutput.ErrorMessages.Count > 0)
                        {
                            sbString.Append("<br /><ul>");

                            for (nCount = 0; nCount < goGatewayOutput.ErrorMessages.Count; nCount++)
                            {
                                sbString.AppendFormat("<li>{0}</li>", goGatewayOutput.ErrorMessages[nCount]);
                            }
                            sbString.Append("</ul>");
                        }

                        szMessage = goGatewayOutput.Message + sbString.ToString();
                        break;
                    default:
                        // unhandled status code  
                        boTransactionSuccessful = false;
                        m_fmFormMode = FORM_MODE.PAYMENT_FORM;
                        szMessage = goGatewayOutput.Message;
                        break;
                }
            }

            if (m_fmFormMode == FORM_MODE.PAYMENT_FORM)
            {
                pnMessagePanel.CssClass = "ErrorMessage";
                pnMessagePanel.Visible = true;
                lbMessageLabel.Text = szMessage;
                pnTransactionResultsPanel.Visible = false;
            }
            else
            {
                pnTransactionResultsPanel.Visible = true;
                pnMessagePanel.Visible = false;

                if (!boTransactionSuccessful)
                {
                    pnTransactionResultsPanel.CssClass = "ErrorMessage";
                }
                else
                {
                    pnTransactionResultsPanel.CssClass = "SuccessMessage";
                }
                
                lbGatewayResponse.Text = szMessage;
                
                // sort out the duplicate transaction reporting
                if (boDuplicateTransaction)
                {
                    pnDuplicateTransactionPanel.Visible = true;
                    lbPreviousTransactionMessage.Text = szPreviousTransactionMessage;
                }

                // the process another link
                if (boTransactionSuccessful == true)
                {
                    Response.Redirect("Thankyou.aspx?id="+szMessage);
                }
                else
                {
                    hlProcessAnother.NavigateUrl = Global.SiteSecureBaseURL + "PaymentForm.aspx";
                }
            }
        }
    }
}
