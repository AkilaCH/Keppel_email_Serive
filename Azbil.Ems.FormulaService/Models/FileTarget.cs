using Azbil.Billing.Logging.Interfaces;
using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azbil.Billing.Service.Models
{
    public class FileTarget : ILogTarget
    {
        public string TargetName { get; set; }

        public LogLevel LogLevel { get; set; }

        public string Layout { get; set; }

        public string LogDestination { get; set; }

        public string LogName { get; set; }

        public string Footer { get; set; }
    }
}
