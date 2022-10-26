using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Logging.Interfaces
{
    public interface ILogTarget
    {
        string TargetName { get; set; }

        LogLevel LogLevel { get; set; }

        string Layout { get; set; }

        string LogDestination { get; set; }

        string LogName { get; set; }

        string Footer { get; set; }
    }
}
