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
        public Boolean SendPasswordResetMail(string email, string name, int code)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.IsBodyHtml = true;
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("nosqlgroep1@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Password reset";
                mail.Body = "Dear "+name+", <br />" +
                            "You have requested to change your password <br />" +
                            "your code is <b>" + code.ToString() + "<b>. <br />" +
                            "Fill in this this code in the applictation to reset your password <br />" +
                            "<br />" +
                            "With kind regards the Garden Groep";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("nosqlgroep1@gmail.com", "Welkom1234");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public Boolean SendNewPasswordMail(string email, string name, string password)
        {
            try
            { 
                MailMessage mail = new MailMessage();
                mail.IsBodyHtml = true;
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("nosqlgroep1@gmail.com");
                mail.To.Add(email);
                mail.Subject = "New Password The Garden Group";
                mail.Body = "Dear " + name + ", <br />" +
                            "A new account has been created for you on The Garden Group's Service Desk Application <br />" +
                            "your username is <b>" + email + "<b>. <br />" +
                            "your password is <b>" + password + "<br />" +
                            "You can log in with this information once you have started the application <br />" +
                            "<br />" +
                            "With kind regards the Garden Group";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("nosqlgroep1@gmail.com", "Welkom1234");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
}
    }
}
