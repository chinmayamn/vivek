using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;


namespace EBS
{
    public partial class Response : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sQS;
            string[] aQS;
            string lsDetail1, lsDetail2, lsDetail;
            string pwd = "ebskey";
            string DR = Request.QueryString["DR"].ToString();
            DR = DR.Replace(' ', '+');
            sQS = Base64Decode(DR);
            DR = RC4.Decrypt(pwd, sQS, false);

            lsDetail = "<TABLE align=center border=0 cellPadding=0 cellSpacing=2 width='100%'>";

            lsDetail += "<tr><th width='90%'><h2 class='co'>EBS Payment Integration Page</h2></th></tr></table>";

            lsDetail += "<center><h3>Response</H3></center>";

            lsDetail += "<table align='center' width='600' cellpadding='2' cellspacing='2' border='0'>";

            lsDetail += "<tr><th colspan='2'>Transaction Details</th><tr></table>";

            Response.Write(lsDetail);

            aQS = DR.Split('&');

            foreach (string param in aQS)
            {

                string[] aParam = param.Split('=');

                lsDetail1 = "<table align='center' width='600' cellpadding='2' cellspacing='2' border='0'>";

                lsDetail1 += "<td align='left'>" + aParam[0] + "</td></br>";

                lsDetail2 = "<td align='left' width='50%'>" + aParam[1] + "</td>";

                lsDetail2 += "</tr></table>";

                lsDetail1 += lsDetail2;

                Response.Write(lsDetail1);

                lsDetail1 = "";

                lsDetail2 = "";

                //Response.Write("<b>" + aParam[0] + "</br> ");

                // Response.Write("<b>"+aParam[0] + "</b> " + aParam[1] + "<br/>");

            }
        }
    
        private string Base64Decode(string sBase64String)
        {
            byte[] sBase64String_bytes =
            Convert.FromBase64String(sBase64String);
            return UnicodeEncoding.Default.GetString(sBase64String_bytes);
            //return UnicodeEncoding.ASCII.GetString(sBase64String_bytes);
        }

        public string base64Decode(string data)
        {
            try
            {
                System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
                System.Text.Decoder utf8Decode = encoder.GetDecoder();

                byte[] todecode_byte = Convert.FromBase64String(data);
                int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
                char[] decoded_char = new char[charCount];
                utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
                string result = new String(decoded_char);
                return result;
            }
            catch (Exception e)
            {
                throw new Exception("Error in base64Decode" + e.Message);
            }
        }
    }
}
