using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Entities.Billing
{
    public partial class MinOffTake
    {
        public BillingUnit billingUnit { get; set; }

        public MinOffTake previousMinOffTakeRecord { get; set; }

        public MinOffTake currentMinOffTakeRecord { get; set; }

        public Customer customer { get; set; }

        public Building block { get; set; }

        public string mode { get; set; }

        public bool DDLEnable { get; set; }

        public bool DILEnable { get; set; }

        public bool DUHEnable { get; set; }

        public bool billExists { get; set; }

        public ReDeclarationDemand ReDeclarationDemand { get; set; }
    }
}
