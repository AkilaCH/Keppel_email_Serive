using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Entities.Billing
{
    public class UnitPrice
    {
        [Key]
        public double? DCMonthlyRate { get; set; } 

        public double? ECRate { get; set; }

        public List<ADLTariff> adlRates { get; set; }
    }
}
