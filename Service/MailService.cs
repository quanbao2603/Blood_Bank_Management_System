using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace Blood_Bank.Service
{
    internal class MailService
    {
        private static string systemEmail = ""; // Gmail hệ thống
        private static string appPassword = "";    // Mật khẩu ứng dụng

        public static void SendEmail(string toEmail, string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage(systemEmail, toEmail, subject, body);

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587)
                {
                    Credentials = new NetworkCredential(systemEmail, appPassword),
                    EnableSsl = true
                };

                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                throw new Exception("Email sending failed: " + ex.Message);
            }
        }
    }
}
