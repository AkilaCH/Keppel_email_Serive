using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Core.Interfaces
{
    public interface IEmailNotification
    {
          string MailHeader { get; set; }

          string MailFooter { get; set; }

          string MailBody { get; set; }

          string MailSubject { get; set; }

          string SenderMailAddress { get; set; }

          string Host { get; set; }

          string SenderMailPassword { get; set; }

          string ContextTextId { get; set; }      

          int MailNotificationID { get; set; }

          string MailNotificationStatus { get; set; }

          List<string> MailReciversAddressList { get; set; }

          string MailContentData { get; set; }

          List<string> MailCcRecipientAddressList { get; set; }
    }
}
