using Azbil.Billing.Logging.Interfaces;
using Azbil.Billing.Service.Bindings;
using Azbil.Billing.Service.Common;
using Azbil.Billing.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using Ninject;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using Azbil.Billing.Business.Interfaces;
using System.Text;

namespace Azbil.Billing.Service.Helpers
{
    public class JobScheduler
    {
        private static readonly IConfiguration _configuration;

        private static readonly ILogManager _logger;

        private static readonly IEmailJob _emailJob;

        private static readonly IGeneralService _generalService;

        private static IKernel _kernel;
        
        static JobScheduler()
        {
            _kernel = new StandardKernel(new ServiceBinding());
            _configuration = _kernel.Get<IConfiguration>();
            _generalService = _kernel.Get<IGeneralService>();
            _logger = _kernel.Get<ILogManager>();
            _emailJob = _kernel.Get<IEmailJob>();
            
        }

        public static void Start()
        {
            try
            {
                _logger.Info("Email Initialization Started " + DateTime.Now);

                ConfigureEmailConfigs();
                InitializeMailNotifyConfigs();
                Global.InitiateNextRunTimes();

                _logger.Info("Email Initialization finished " + DateTime.Now);

                //if (Convert.ToBoolean(_configuration.GetSection("DataPatchService")["IsDataPatch"]))
                //{
                //    DataPatchTrigger();
                //}
                //else
               // {
                    JobTrigger();
                //}
            }
            catch (Exception ex)
            {
                _logger.Error("An error occurred while initializing the service " + ex);
            }
        }

        //private static void DataPatchTrigger()
        //{
        //    var startTime = _configuration.GetSection("DataPatchService")["StartTime"];

        //    var endTime = _configuration.GetSection("DataPatchService")["EndTime"];

        //    var dataPatchCycleMinutes = _configuration.GetSection("DataPatchCycleMinutes").Value;

        //    var formulaTrigger = new FormulaTrigger(_emailJob, _logger);

        //    formulaTrigger.TriggerFormulaPatch(Convert.ToDateTime(startTime), Convert.ToDateTime(endTime), Convert.ToInt32(dataPatchCycleMinutes));
        //}

        private static void JobTrigger()
        {
            IScheduler scheduler = StdSchedulerFactory.GetDefaultScheduler().Result;

            scheduler.Start();

            IJobDetail job = JobBuilder.Create<DataProcessJob>().Build();

            var startTime = EmailHelper.GetInitialScheduledTime();

            _logger.Info("Calculated datetime for the job to be run on " + startTime);

            var delayedTimeInCron = _configuration.GetSection("DelayedTimeCron").Get<string>();

            ITrigger trigger = TriggerBuilder.Create()
                    .WithIdentity("EmailJob", "Email")
                    .WithCronSchedule(delayedTimeInCron)
                    .StartAt(new DateTimeOffset(startTime.ToUniversalTime()))
                    .WithPriority(1)
                    .UsingJobData(new JobDataMap((IDictionary<string, object>)new Dictionary<string, object>() { { "logger", _logger } }))
                    .UsingJobData(new JobDataMap((IDictionary<string, object>)new Dictionary<string, object>() { { "emailJob", _emailJob } }))
                    .Build();

            scheduler.ScheduleJob(job, trigger);
            
            _logger.Info("Job has been scheduled to be run on " + trigger.GetNextFireTimeUtc().Value.LocalDateTime);
        }

        private static void ConfigureEmailConfigs()
        {
            var emailConfig = new Core.Classes.EmailConfig();
            emailConfig.Username = _configuration.GetSection("Username").Value;
            emailConfig.Password = _configuration.GetSection("Password").Value;
            emailConfig.Host = _configuration.GetSection("Host").Value;
            emailConfig.Port = _configuration.GetSection("Port").Value;
            emailConfig.EnableSsl = _configuration.GetSection("EnableSsl").Value;
            Global.EmailConfig = emailConfig;
            Global.ConfiguredDate = DateTime.Parse(_configuration.GetSection("ConfigureDate").Value);
            Global.EmailSendDay = _configuration.GetSection("EmailSendDay").Get<int>();
        }        

        public static void InitializeMailNotifyConfigs()
        {
            try
            {
                Global.MailNotifyConfigs = _generalService.GetMailNotifiConfigs();
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
            }
        }
    }
}
