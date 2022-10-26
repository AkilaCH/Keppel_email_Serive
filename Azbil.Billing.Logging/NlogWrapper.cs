using Azbil.Billing.Logging.Interfaces;
using NLog;
using NLog.Config;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Logging
{
    [Serializable]
    public class NlogWrapper : ILogManager
    {
        [NonSerialized]
        private Logger _logger;

        [NonSerialized]
        private LoggingConfiguration _config;

        public NlogWrapper(IEnumerable<ILogTarget> fileTargets = null, IEnumerable<ILogTarget> dbTargets = null)
        {
            _config = new LoggingConfiguration();

            if (fileTargets != null && fileTargets.Any())
            {
                GetFileTargets(fileTargets);
            }

            LogManager.Configuration = _config;
            _logger = LogManager.GetLogger("");
        }

        private void GetFileTargets(IEnumerable<ILogTarget> fileTargets)
        {
            foreach (var fileTarget in fileTargets)
            {

                var filePath = GetFilePath(fileTarget.LogDestination);
                var fileName = GetFileName(fileTarget.LogName, fileTarget.LogLevel);

                var target = new FileTarget(fileTarget.TargetName)
                {
                    FileName = filePath + fileName,
                    Layout = fileTarget.Layout,
                    Encoding = System.Text.Encoding.UTF8,
                    ArchiveAboveSize = 20000000,
                    ArchiveNumbering = ArchiveNumberingMode.DateAndSequence,
                    ArchiveEvery = FileArchivePeriod.Day,
                    Footer = fileTarget.Footer
                };

                _config.AddTarget(target);

                if (fileTarget.LogLevel != null)
                {
                    _config.AddRuleForOneLevel(fileTarget.LogLevel, target);
                }
                else
                {
                    _config.AddRuleForAllLevels(target);
                }
            }
        }

        private string GetFileName(string logName, LogLevel logLevel)
        {
            var fileName = logLevel?.ToString() ?? "Log";
            fileName = logName ?? fileName;
            fileName += ".log";

            return fileName;
        }

        private string GetFilePath(string logDestination)
        {
            var filePath = "${basedir}Logs\\";

            if (logDestination != null)
            {
                filePath = logDestination + "\\";
            }

            return filePath;
        }

        public void Debug(string debug) => _logger.Debug(debug);

        public void Error(string error) => _logger.Error(error);

        public void Fatal(string fatal) => _logger.Fatal(fatal);

        public void Info(string info) => _logger.Info(info);

        public void Trace(string trace) => _logger.Trace(trace);

        public void Warning(string warning) => _logger.Warn(warning);

        public void Debug(Exception exception, string debug) => _logger.Debug(exception, debug);

        public void Error(Exception exception, string error) => _logger.Error(exception, error);

        public void Fatal(Exception exception, string fatal) => _logger.Fatal(exception, fatal);

        public void Info(Exception exception, string info) => _logger.Info(exception, info);

        public void Trace(Exception exception, string trace) => _logger.Trace(exception, trace);

        public void Warning(Exception exception, string warning) => _logger.Warn(exception, warning);

        public void Debug(Exception exception) => _logger.Debug(exception);

        public void Error(Exception exception) => _logger.Error(exception);

        public void Fatal(Exception exception) => _logger.Fatal(exception);

        public void Info(Exception exception) => _logger.Info(exception);

        public void Trace(Exception exception) => _logger.Trace(exception);

        public void Warning(Exception exception) => _logger.Warn(exception);
    }
}
