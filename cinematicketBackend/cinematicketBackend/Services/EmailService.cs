using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

namespace CinematicketBackend.Services
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;

        public EmailService(IConfiguration config)
        {
            _config = config;
        }

        public void SendEmail(string to, string subject, string body)
        {
           
            var host = _config["EmailSettings:Host"];
            var portStr = _config["EmailSettings:Port"];
            var senderName = _config["EmailSettings:SenderName"];
            var senderEmail = _config["EmailSettings:SenderEmail"];
            var password = _config["EmailSettings:Password"];

            if (string.IsNullOrEmpty(host)) throw new Exception("Błąd: Brak 'EmailSettings:Host' w appsettings.json");
            if (string.IsNullOrEmpty(portStr)) throw new Exception("Błąd: Brak 'EmailSettings:Port' w appsettings.json");
            if (string.IsNullOrEmpty(senderEmail)) throw new Exception("Błąd: Brak 'EmailSettings:SenderEmail' w appsettings.json");
            if (string.IsNullOrEmpty(password)) throw new Exception("Błąd: Brak 'EmailSettings:Password' w appsettings.json");

            if (!int.TryParse(portStr, out int port)) throw new Exception("Błąd: Port w konfiguracji nie jest liczbą.");

            var email = new MimeMessage();
            email.From.Add(new MailboxAddress(senderName, senderEmail));
            email.To.Add(MailboxAddress.Parse(to));
            email.Subject = subject;
            email.Body = new TextPart(TextFormat.Html) { Text = body };

            using var smtp = new MailKit.Net.Smtp.SmtpClient();
            try
            {
                smtp.Connect(host, port, SecureSocketOptions.StartTls);
                smtp.Authenticate(senderEmail, password);
                smtp.Send(email);
            }
            catch (Exception ex)
            {
                throw new Exception($"Błąd wysyłania SMTP: {ex.Message}", ex);
            }
            finally
            {
                smtp.Disconnect(true);
            }
        }
    }
}