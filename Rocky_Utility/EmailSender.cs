using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Rocky_Utility
{
    public class EmailSender : IEmailSender
    {
        private readonly IConfiguration _configuration;
        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            return Execute(email, subject, htmlMessage);
        }

        public async Task Execute(string email, string subject, string body)
        {
            using (var message = new MailMessage(WC.EmailAdmin, email))
            {
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = true;
                using (var client = new SmtpClient("smtp.gmail.com", 587))
                {
                    client.Credentials = new NetworkCredential("ozchivit12@gmail.com", "xzhymbulbtnafwpm");
                    client.EnableSsl = true;

                    await client.SendMailAsync(message);
                }
            }
        }
    }
}
