using Azbil.Billing.Service.Models;
using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azbil.Billing.Service.Helpers
{
    public class FileTargetLogger
    {
        public static List<FileTarget> GetFileTargets()
        {
            var fileTargets = new List<FileTarget>();

            fileTargets.Add(new FileTarget
            {
                TargetName = "trace",
                LogLevel = LogLevel.Trace,
                Layout = "${longdate}, ${level:uppercase=true}${newline}${message}${newline}${exception}",
                Footer = "${newline}"
            });

            fileTargets.Add(new FileTarget
            {
                TargetName = "debug",
                LogLevel = LogLevel.Debug,
                Layout = "${longdate}, ${level:uppercase=true}${newline}${message}${newline}${exception}",
                Footer = "${newline}"
            });

            fileTargets.Add(new FileTarget
            {
                TargetName = "error",
                LogLevel = LogLevel.Error,
                Layout = "${longdate}, ${level:uppercase=true}${newline}${message}${newline}${exception}",
                Footer = "${newline}"
            });

            fileTargets.Add(new FileTarget
            {
                TargetName = "info",
                LogLevel = LogLevel.Info,
                Layout = "${longdate}, ${level:uppercase=true}\t${message}${newline}${exception}",
                Footer = ""
            });

            fileTargets.Add(new FileTarget
            {
                TargetName = "warning",
                LogLevel = LogLevel.Warn,
                Layout = "${longdate}, ${level:uppercase=true}${newline}${message}${newline}${exception}",
                Footer = "${newline}"
            });

            return fileTargets;
        }
    }
}
