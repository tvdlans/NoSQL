using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Controller
{
    public class ConSendMail
    {
        public Boolean SendMail(string email, string name, int code)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.IsBodyHtml = true;
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");


                mail.From = new MailAddress("nosqlgroep1@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Password reset";

                //this is the body of the mail
                mail.Body = "Dear "+name+", <br />" +
                            "You have requested to change your password <br />" +
                            "your code is <b>" + code.ToString() + "<b>. <br />" +
                            "Fill in this this code in the applictation to reset your password <br />" +
                            "<br />" +
                            "With kind regards the Garden Groep";

                //send the mail
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("nosqlgroep1@gmail.com", "Welkom1234");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
