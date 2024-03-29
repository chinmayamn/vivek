<%@ Page Language="C#" AutoEventWireup="true" CodeFile="PaymentForm.aspx.cs" Inherits="MyCompanyName.PaymentForm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="CSS/StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body id="BodyTag" runat="server">
    <form name="ACSForm" action="<%= m_szACSURL %>" method="post" target="ACSFrame">
        <input type="hidden" name="PaReq" value="<%= m_szPaREQ %>" />
        <input type="hidden" name="MD" value="<%= m_szCrossReference %>" />
        <input type="hidden" name="TermUrl" value="<%= m_szTermURL %>" />
    </form>

    <form id="form1" runat="server">
    <div style="width:800px;margin:auto">
        <asp:HiddenField ID="hfFormMode" runat="server" Value="PAYMENTFORM" />
           
        <asp:Panel ID="pnMessagePanel" runat="server" Visible="false">
            <asp:Label ID="lbMessageLabel" runat="server" />
        </asp:Panel>

        <asp:MultiView ID="PaymentFormMultiView" runat="server" ActiveViewIndex="0">
            <asp:View ID="PaymentFormView" runat="server">
                <div class="ContentRight">
                    <div class="ContentHeader">
                        Order Details
                    </div>
	                <div class="FormItem">
	                    <div class="FormLabel">Amount:</div>
	                    <div class="FormInputTextOnly">
                            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                            &nbsp;GBP</div>
                        <asp:HiddenField ID="hfAmount" runat="server" />
                        <asp:HiddenField ID="hfCurrencyISOCode" runat="server" Value="826" />
	                </div>
	                <div class="FormItem">
	                    <div class="FormLabel">Order Description:</div>
	                    <div class="FormInputTextOnly">A Test Order</div>
                        <asp:HiddenField ID="hfOrderID" runat="server"  />
                        <asp:HiddenField ID="hfOrderDescription" runat="server" Value="A Test Order" />
	                </div>
	                <div class="ContentRight">
	                    <div class="ContentHeader">
	                        Card Details
	                    </div>
	                </div>
	                <div class="FormItem">
	                    <div class="FormLabel">Name On Card:</div>
	                    <div class="FormInput">
	                        <asp:TextBox ID="tbCardName" runat="server" CssClass="InputTextField" MaxLength="50" />
	                    </div>
	                </div>
	                <div class="FormItem">
	                    <div class="FormLabel">Card Number:</div>
	                    <div class="FormInput">            
	                        <asp:TextBox ID="tbCardNumber" runat="server" CssClass="InputTextField" MaxLength="20" />
	                    </div>
	                </div>
	                <div class="FormItem">
	                    <div class="FormLabel">
	                        Expiry Date:
	                    </div>
	                    <div class="FormInput">
	                        <asp:DropDownList ID="ddExpiryDateMonth" runat="server" Width="45px">
	                        </asp:DropDownList>
	                        /
	                        <asp:DropDownList ID="ddExpiryDateYear" runat="server" Width="55px">
	                        </asp:DropDownList>
	                    </div>
	                </div>
	                <div class="FormItem">
	                    <div class="FormLabel">
	                        Start Date:
	                    </div>
	                    <div class="FormInput">
	                        <asp:DropDownList ID="ddStartDateMonth" runat="server" Width="45px">
	                        </asp:DropDownList>
	                        /
	                        <asp:DropDownList ID="ddStartDateYear" runat="server" Width="55px">
	                        </asp:DropDownList>
	                    </div>
	                </div>
	                <div class="FormItem">
	                    <div class="FormLabel">Issue Number:</div>
	                    <div class="FormInput">
	                        <asp:TextBox ID="tbIssueNumber" runat="server" CssClass="InputTextField" MaxLength="2" Width="50px" />
	                    </div>
	                </div>
	                <div class="FormItem">
	                    <div class="FormLabel">CV2:</div>
	                    <div class="FormInput">
	                        <asp:TextBox ID="tbCV2" runat="server" CssClass="InputTextField" MaxLength="4" Width="50px" />
	                    </div>
	                </div>
                </div>
                
                <div class="ContentRight">
                    <div class="ContentHeader">
                        Customer Details
                    </div>
	                <div class="FormItem">
	                    <div class="FormLabel">Address:</div>
	                    <div class="FormInput">
	                        <asp:TextBox ID="tbAddress1" runat="server" CssClass="InputTextField" MaxLength="100" />
	                    </div>
	                </div>
	                <div class="FormItem">
	                    <div class="FormLabel">&nbsp</div>
	                    <div class="FormInput">
	                        <asp:TextBox ID="tbAddress2" runat="server" CssClass="InputTextField" MaxLength="50" />
	                    </div>
	                </div>
	                <div class="FormItem">
	                    <div class="FormLabel">&nbsp</div>
	                    <div class="FormInput">
	                        <asp:TextBox ID="tbAddress3" runat="server" CssClass="InputTextField" MaxLength="50" />
	                    </div>
	                </div>
	                <div class="FormItem">
	                    <div class="FormLabel">&nbsp</div>
	                    <div class="FormInput">
	                        <asp:TextBox ID="tbAddress4" runat="server" CssClass="InputTextField" MaxLength="50" />
	                    </div>
	                </div>
	                <div class="FormItem">
	                    <div class="FormLabel">City:</div>
	                    <div class="FormInput">
	                        <asp:TextBox ID="tbCity" runat="server" CssClass="InputTextField" MaxLength="50" />
	                    </div>
	                </div>
	                <div class="FormItem">
	                    <div class="FormLabel">State:</div>
	                    <div class="FormInput">
	                        <asp:TextBox ID="tbState" runat="server" CssClass="InputTextField" MaxLength="50" />
	                    </div>
	                </div>
	                <div class="FormItem">
	                    <div class="FormLabel">Post Code:</div>
	                    <div class="FormInput">
	                        <asp:TextBox ID="tbPostCode" runat="server" CssClass="InputTextField" MaxLength="50" />
	                    </div>
	                </div>
	                <div class="FormItem">
	                    <div class="FormLabel">
	                        Country:
	                    </div>
	                    <div class="FormInput">
	                        <asp:DropDownList ID="ddCountries" runat="server" Width="200px">
	                            <asp:ListItem></asp:ListItem>
	                        </asp:DropDownList>
	                    </div>
	                </div>
	                <div class="FormItem">
	                    <div class="FormSubmit">
	                        <asp:Button ID="SubmitButton" runat="server" 
	                            Text="Submit For Processing" 
	                            OnClick="SubmitButton_Click" />
	                    </div>
	                </div>
                </div>
            </asp:View>
            <asp:View ID="ThreeDSecureView" runat="server">
                <iframe ID="ACSFrame" name="ACSFrame" width="800" height="400" frameborder="0" runat="server"></iframe>        
            </asp:View>
            <asp:View ID="ResultsView" runat="server">
                <asp:Panel ID="pnTransactionResultsPanel" runat="server" Visible="false">
                    <div class="TransactionResultsItem">
                        <div class="TransactionResultsLabel">Payment Processor Response:</div>    
                        <div class="TransactionResultsText"><asp:Label ID="lbGatewayResponse" runat="server" /></div>
                    </div>
                    <asp:Panel ID="pnDuplicateTransactionPanel" runat="server" Visible="false">
                        <div style="color:#000;margin-top:10px">
						    A duplicate transaction means that a transaction with these details
							has already been processed by the payment provider. The details of
							the original transaction are given below
					    </div>
						<div class="TransactionResultsItem" style="margin-top:10px">
						    <div class="TransactionResultsLabel">Previous Transaction Response:</div>
						    <div class="TransactionResultsText"><asp:Label ID="lbPreviousTransactionMessage" runat="server" /></div>
					    </div>
                    </asp:Panel>
                    <div style="margin-top:10px">
                        <asp:HyperLink ID="hlProcessAnother" runat="server">Process Another</asp:HyperLink>
                    </div>
                </asp:Panel>
            </asp:View>
        </asp:MultiView>
    </div>
    </form>
</body>
</html>
