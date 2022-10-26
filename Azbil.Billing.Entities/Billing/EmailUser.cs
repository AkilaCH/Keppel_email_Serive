using Azbil.Billing.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Entities.Billing
{
    public class EmailUser : IEntity
    {
        public int EmailUserId { get; set; }

        public int MailNotifiConfigId { get; set; }
        
        public int UserId { get; set; }
        
        public string Status { get; set; }
    }
}
