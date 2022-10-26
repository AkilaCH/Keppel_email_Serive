using Azbil.Billing.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Core.Classes
{
    public class EmailNotification : IEmailNotification
    {
        public string MailHeader { get; set; }

        public string MailFooter { get; set; }

        public string MailBody { get; set; }

        public string MailSubject { get; set; }

        public string SenderMailAddress { get; set; }

        public string Host { get; set; }

        public string SenderMailPassword { get; set; }

        public string ContextTextId { get; set; }
        
        public int MailNotificationID { get; set; }

        public string MailNotificationStatus { get; set; }

        public List<string> MailReciversAddressList { get; set; }

        public string MailContentData { get; set; }

        public List<string> MailCcRecipientAddressList { get; set; }
    }
}
