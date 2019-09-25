using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Oasis.utils
{
    public class EmailSender
    {
        // Please use your API KEY here.
        private const String API_KEY = "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";

        public void Send(String subject, String contents)
        {
            var client = new SendGridClient(API_KEY);
            var from = new EmailAddress("noreply@localhost.com", "FIT5032 Example Email User");
            var to = new EmailAddress("nche0024@student.monash.edu", "");
            var plainTextContent = contents;
            var htmlContent = "<p>" + contents + "</p>";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            var response = client.SendEmailAsync(msg);
        }
    }
}