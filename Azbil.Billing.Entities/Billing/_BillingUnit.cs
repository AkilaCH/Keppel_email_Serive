using Azbil.Billing.Entities.EnergyManagement;
using Azbil.Billing.Entities.UserManagement;
using System;
using System.Collections.Generic;

namespace Azbil.Billing.Entities.Billing
{
    public partial class BillingUnit
    {
        public DateTime fromDate { get; set; }

        public DateTime toDate { get; set; }

        public bill_summary monthlyBillRecord { get; set; }

        public IEnumerable<daily_summary_cooling> monthlyADLRecords { get; set; }

        public Owner owner { get; set; }

        public Customer customer { get; set; }

        public Building block { get; set; }

        public UnitPrice unitPrice { get; set; }

        public MinOffTake minOffTake { get; set; }

        public double dcCharge { get; set; }

        public double ecCharge { get; set; }

        public double chargeECQuantity { get; set; }

        public double minOffTakeShortFall { get; set; }

        public double minOffTakeCharge { get; set; }

        public double ecSum { get; set; }

        public MonthlyBillSummary MonthlyBillSummary { get; set; }

        public IEnumerable<ADLRecord> ADLRecords { get; set; }

        public IEnumerable<BillingUnitConfig> configParams { get; set; }

        public IEnumerable<BillingUnitConfig> billingUnitConfig { get; set; }

        public string tariffStatus { get; set; }

        public string blockCode { get; set; }

        public bool hasVariableA { get; set; }

        public bool hasVariableB { get; set; }

        public bool hasVariableC { get; set; }

        public bool hasVariableD { get; set; }

        public bool hasVariableE { get; set; }

        public bool hasVariableF { get; set; }

        public bool hasVariableG { get; set; }

        public bool isEstimateBill { get; set; }

        public double perDayConsuption { get; set; }
        public int EstimateBillDays { get; set; }

        public DateTime EstimateBillToDate { get; set; }

        public double FixedDCRate { get; set; }
        public double FixedDemandCharge { get; set; }

        public double FixedDCQuantity { get; set; }

    }
}
