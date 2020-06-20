using System;
using System.Collections.Generic;
using System.Web;
using System.Net.Mail;

/// <summary>
/// Summary description for mailing
/// </summary>
public class mailing
{
	public mailing()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void mymail(string email,string msg,string subject)
    {
          string em = email;


            string mto = em;
            string mFrom = "sales@freshprawnsonline.com";

            try
            {
                if (mto != "" && mFrom != "")
                {

                    MailMessage message = new MailMessage();
                    message.From = new MailAddress(mFrom);
                    message.To.Add(mto);
                    message.IsBodyHtml = true;

      message.Subject =subject;
                    message.Body = msg;
                    SmtpClient smtp = new SmtpClient("localhost", 25);

                    smtp.Send(message);
                    message.Dispose();




                }

                else
                {
                    MessageBox msg2 = new MessageBox();
                    msg2.Show("Send feed back again after some time");

                }



            }
            catch (Exception ex)
            {

                MessageBox msg3 = new MessageBox();
                msg3.Show(ex.ToString());

            }





         
    }
}
