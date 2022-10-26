using Azbil.Billing.Util.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azbil.Billing.Service.Interfaces
{
    public interface IEmailJob
    {
        void Process(Core.Classes.MailNotifyConfig mailNotifyConfig);
    }
}
