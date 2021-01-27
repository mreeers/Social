using MailKit.Net.Smtp;
using MimeKit;
using System.Threading.Tasks;

namespace Social.Application.Email
{
   public class EmailService
   {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Дополнительная мера социальной поддержки", "socialtestsurgut@gmail.com"));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.gmail.com", 587, false);
                await client.AuthenticateAsync("socialtestsurgut@gmail.com", "r9PUVDgyrVvd9bh");
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
   }
}
