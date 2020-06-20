using System;
using System.Web.UI.WebControls;
using com.toml.dp.util;

public class EncDec : System.Web.UI.Page {
	protected HiddenField requestparams;
	protected Button Button1;
	protected TextBox merchantId, collaboratorId, operatingMode, country, currency, amount, orderNumber, otherDetails, successUrl, failureUrl, gatewayId, gatewayName, gatewayType;

	int keySize = 128;
	string completeEncodedKey = "mFLZSVqv3ZORJOMiX1FL5Q==";

	public EncDec() {
		Page.Init += new System.EventHandler(Page_Init);
	}

	protected void Page_Init(object sender, EventArgs e) {
		Button1.Click += new System.EventHandler (this.Button1_Click);
	}

	public void Button1_Click (object sender, System.EventArgs e) {
		string requestString = merchantId.Text + "|" + operatingMode.Text + "|" + country.Text + "|" + currency.Text + "|" + amount.Text + "|" + orderNumber.Text + "|" + otherDetails.Text + "|" + successUrl.Text + "|" + failureUrl.Text + "|" + collaboratorId.Text + "|" + gatewayId.Text + "-" + gatewayName.Text + "|" + gatewayType.Text;
		string encryptedText = AES128Bit.Encrypt(requestString, completeEncodedKey, keySize);
		requestparams.Value = encryptedText;
	}
}