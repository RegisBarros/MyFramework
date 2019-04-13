using System.Threading.Tasks;

namespace MyFramework.SmtpServer
{
    public class Smtp
    {
        public async Task Send(Email email)
        {
            // do something nice
        }
    }

    public class Email
    {
        public Email(string from, string to, string body, string subject, byte[] attachement)
        {
            From = from;
            To = to;
            Body = body;
            Subject = subject;
            Attachement = attachement;
        }

        public string From { get; private set; }
        public string To { get; private set; }
        public string Body { get; private set; }
        public string Subject { get; private set; }
        public byte[] Attachement { get; private set; }
    }
}
