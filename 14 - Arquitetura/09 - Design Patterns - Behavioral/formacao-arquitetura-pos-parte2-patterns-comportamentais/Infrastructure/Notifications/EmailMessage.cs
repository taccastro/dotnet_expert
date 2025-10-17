﻿namespace AwesomeShopPatterns.API.Infrastructure.Notifications
{
    public class EmailMessage : IMarketingMessage
    {
        public EmailMessage(string from, string to, string subject, string content)
        {
            From = from;
            To = to;
            Subject = subject;
            Content = content;
        }

        public string From { get; private set; }

        public string To { get; private set; }

        public string Subject { get; private set; }

        public string Content { get; private set; }
    }
}
