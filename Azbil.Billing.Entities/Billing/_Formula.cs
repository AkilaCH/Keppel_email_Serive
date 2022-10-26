using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Entities.Billing
{
    public partial class Formula
    {
        public string formulaCategory { get; set; }

        public FormulaType formulaType { get; set; }

        public double calcResult { get; set; }

        public int formulaTypeId { get; set; }

    }
}
