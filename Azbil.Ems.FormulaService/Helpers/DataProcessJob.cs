using Azbil.Billing.Logging.Interfaces;
using Azbil.Billing.Service.Interfaces;
using Quartz;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Service.Helpers
{
    [DisallowConcurrentExecution]
    public class DataProcessJob : IJob
    {
        private ILogManager _logger;

        private IEmailJob _emailJob;

        public async Task Execute(IJobExecutionContext context)
        {
            JobDataMap dataMap = context.MergedJobDataMap;

            _logger = (ILogManager)dataMap["logger"];
            _emailJob = (IEmailJob)dataMap["emailJob"];

            await ProcessFormula();
        }

        public void Execute() => ProcessFormula().Wait();

        private async Task ProcessFormula()
        {
            await Task.Run(() =>
            {
                try
                {
                    _logger.Info("Job has been triggered at :" + DateTimeOffset.Now);

                    var emailTrigger = new EmailTrigger(_emailJob, _logger);
                    emailTrigger.TriggerEmails();
                }
                catch (Exception ex)
                {
                    _logger.Error(ex);
                }
            });
        }
    }
}
