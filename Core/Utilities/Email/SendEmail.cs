using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Email
{
    public  class SendEmail
    {
       
       public void send(string mailAddress,ref int code)
        {

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential("email_Address", "Password");


            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("efedenizerkprl@gmail.com");
            mail.To.Add(mailAddress);
            mail.Subject = "Account Verification";
            mail.IsBodyHtml = true;
            mail.Body = "Hi, I'm the cat who owns this place. activate the account to make flawless phones and find partners for your beautiful company " +
                "type this activation code in the box in the pop-up window. Code is: " + code + " have a fun. :)";
            smtpClient.Send(mail);
        } 
    }
}
