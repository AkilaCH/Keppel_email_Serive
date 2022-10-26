using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Util
{
    public class Common
    {
        public static DateTime RoundUp(DateTime dt, TimeSpan d) => new DateTime((dt.Ticks + d.Ticks - 1) / d.Ticks * d.Ticks, dt.Kind);

        public static DateTime RoundDown(DateTime dt, TimeSpan d) => new DateTime(dt.Ticks - dt.Ticks % d.Ticks, dt.Kind);

    }
}
