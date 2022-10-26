using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Core.Interfaces
{
    public interface IMailNotifyConfig
    {
        int MailConfigId { get; set; }

        string ContextTextId { get; set; }

        string Subject { get; set; }

        string Header { get; set; }
        
        string MailContentTemplate { get; set; }
        
        string Footer { get; set; }

        int Frequency { get; set; }

        string Status { get; set; }
    }
}
