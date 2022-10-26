using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Entities.Billing
{
    public partial class VariableValue
    {
        public string variableFuncTextId { get; set; }

        public string mode { get; set; }

        public string unit { get; set; }

        public List<VariableCondition> conditions { get; set; }

        public string Category { get; set; }
    }
}
