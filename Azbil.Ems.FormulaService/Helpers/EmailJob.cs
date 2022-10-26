using Azbil.Billing.Business.Interfaces;
using Azbil.Billing.Core.Interfaces;
using Azbil.Billing.Service.Bindings;
using Azbil.Billing.Service.Common;
using Azbil.Billing.Service.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azbil.Billing.Service.Helpers
{
    public class EmailJob : IEmailJob
    {
        private IEmailService _emailService;

        public EmailJob(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void Process(Core.Classes.MailNotifyConfig mailNotifyConfig)
        {
            var now = DateTime.Now;
            var emailDate = now.AddDays(-1);
            _emailService.Year = emailDate.Year;
            _emailService.Month = emailDate.Month;
            _emailService.Day = emailDate.Day;
            _emailService.SendNotifyAuditlogApproval(Global.EmailConfig, mailNotifyConfig);

            //if (frequency == EmailFrequency.Day)
            //{

            //}
            //if (frequency == EmailFrequency.Month)
            //{
               
               
            //}
            //if (frequency == EmailFrequency.ThreeMonth)
            //{

            //}
            //if (frequency == EmailFrequency.Year)
            //{

            //}
          
        }

    }
}
