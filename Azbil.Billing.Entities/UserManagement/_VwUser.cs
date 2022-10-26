using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Entities.UserManagement
{
    public partial class VwUser
    {
        public DateTime pwChangedDate { get; set; }
        public DateTime lastLoginDate { get; set; }
    }
}
