using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace IsaProject.Areas.Identity
{
    public class EmailSender : IEmailSender
    {

        // Our private configuration variables
        private readonly string _host;
        private readonly int _port;
        private readonly bool _enableSsl;
        private readonly string _userName;
        private readonly string _password;

        // Get our parameterized configuration
        public EmailSender(string host, int port, bool enableSsl, string userName, string password)
        {
            _host = host;
            _port = port;
            _enableSsl = enableSsl;
            _userName = userName;
            _password = password;
        }

        // Use our configuration to send the email by using SmtpClient
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(_host, _port)
            {
                Credentials = new NetworkCredential(_userName, _password),
                EnableSsl = _enableSsl
            };
            return client.SendMailAsync(
                new MailMessage(_userName, email, subject, htmlMessage) { IsBodyHtml = true }
            );

        }
    }
}