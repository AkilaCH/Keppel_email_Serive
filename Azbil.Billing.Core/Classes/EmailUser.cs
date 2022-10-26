using Azbil.Billing.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Core.Classes
{
    public class EmailUser : IEmailUser
    {
        public int EmailUserId { get; set; }

        public int MailNotifyConfigId { get; set; }

        public int UserId { get; set; }

        public string Status { get; set; }
    }
}
