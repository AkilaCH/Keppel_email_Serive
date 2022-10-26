using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Core.Interfaces
{
    public interface IEmailUser
    {
        int EmailUserId { get; set; }

        int MailNotifyConfigId { get; set; }

        int UserId { get; set; }

        string Status { get; set; }
    }
}
