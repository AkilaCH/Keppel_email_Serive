using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Entities.Billing
{
    public partial class Building
    {
        public int cBlockId { get; set; }

        public string plantTextId { get; set; }

        public string plantName { get; set; }

        public Plant plant { get; set; }
    }
}
