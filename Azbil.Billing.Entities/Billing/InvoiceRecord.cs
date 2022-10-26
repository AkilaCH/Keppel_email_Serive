using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Entities.Billing
{
    public class InvoiceRecord
    {
        public MonthlyBillSummary monthlyBillRecord { get; set; }

        public string arInvoiceCode { get; set; }

        public string documentNo { get; set; }

        public UnitPrice unitPrice { get; set; }
    }
}
