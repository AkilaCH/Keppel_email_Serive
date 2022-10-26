using Azbil.Billing.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Entities.Billing
{
    public class _MailNotifyConfig : IEntity
    {
        public int MailConfigId { get; set; }

        public string ContextTextId { get; set; }

        public string Subject { get; set; }
        
        public string Header { get; set; }
        
        public string MailContentTemplate { get; set; }
        
        public string Footer { get; set; }
        
        public string CCRecipientAddressList { get; set; }

        public int Frequency { get; set; }

        public int Status { get; set; }
    }
}
