using Azbil.Billing.Entities.Billing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Entities.Billing
{
    public partial class Customer
    {
        public int cCstId { get; set; }

        public List<string> address { get; set; }

        public IEnumerable<BillingUnit> billingUnits { get; set; }

        public string currency { get; set; }
    }
}
