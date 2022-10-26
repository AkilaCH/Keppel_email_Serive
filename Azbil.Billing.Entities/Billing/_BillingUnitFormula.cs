using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Entities.Billing
{
    public partial class BillingUnitFormula
    {
        public BillingUnit billingUnit { get; set; }

        public List<BillingUnitFormula> billingUnitFormulaList { get; set; }

        public List<BillingUnitConfig> billingUnitConfigList { get; set; }

        public DateTime effectiveTo { get; set; }

        public string FormulaText { get; set; }

        public bool tariffRecordExists { get; set; }
    }
}
