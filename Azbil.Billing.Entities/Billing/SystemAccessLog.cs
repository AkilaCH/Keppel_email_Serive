using Azbil.Billing.Entities.UserManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Entities.Billing
{
    public class SystemAccessLog
    {
        public int userId { get; set; }
        public int profileId { get; set; }
        public DateTime loginTime { get; set; }
        public DateTime logoutTime { get; set; }
        public string logoutMethod { get; set; }
        public List<AuditLog> activityLogs { get; set; }
    }
}
