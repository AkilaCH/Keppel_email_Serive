using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Entities.Billing
{
    public class ChartPeakLoad
    {
        public string spikeTime { get; set; }

        public double peakLoad { get; set; }
    }
}
