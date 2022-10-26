using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Entities.Billing
{
    public partial class Variable
    {
        public List<VariableCondition> constraints { get; set; }

        public int SequenceNo { get; set; }

        public float resultValue { get; set; }
    }
}
