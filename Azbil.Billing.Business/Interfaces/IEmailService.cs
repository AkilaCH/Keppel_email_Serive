using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Business.Interfaces
{
    public interface IEmailService
    {
        int Year { get; set; }

        int Month { get; set; }

        int Day { get; set; }

        int SendNotifyAuditlogApproval(Core.Classes.EmailConfig emailConfig, Core.Classes.MailNotifyConfig mailNotifyConfig);

        Dictionary<string, string> notifyAuditlogApprovalTemplateData();
    }
}
