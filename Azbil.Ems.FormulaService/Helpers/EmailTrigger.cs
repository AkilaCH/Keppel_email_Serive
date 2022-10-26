using Azbil.Billing.Logging.Interfaces;
using Azbil.Billing.Service.Common;
using Azbil.Billing.Service.Interfaces;
using Azbil.Billing.Util.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Azbil.Billing.Service.Helpers
{
	public class EmailTrigger
	{
		private IEmailJob _emailJob;

		private ILogManager _logger;

		public EmailTrigger(IEmailJob emailJob, ILogManager logger)
		{
			_emailJob = emailJob;
			_logger = logger;
		}

		public void TriggerEmails()
		{
			try
			{
				var mailNotifyConfigs = Global.MailNotifyConfigs;
				var nextRunTimes = Global.NextRunTimes;

				foreach (var mailNotifyConfig in mailNotifyConfigs.Where(a => a.Frequency != 0))
				{
					if ((EmailFrequency)mailNotifyConfig.Frequency == EmailFrequency.Day && nextRunTimes[EmailFrequency.Day] < DateTime.Now)
					{
						_logger.Info("Triggerred: " + EmailFrequency.Day.ToString());
						ProcessEmails(mailNotifyConfig);
					}
					if ((EmailFrequency)mailNotifyConfig.Frequency == EmailFrequency.Week && nextRunTimes[EmailFrequency.Week] < DateTime.Now)
					{
						_logger.Info("Triggerred: " + EmailFrequency.Week.ToString());
						ProcessEmails(mailNotifyConfig);
					}
					if ((EmailFrequency)mailNotifyConfig.Frequency == EmailFrequency.Month && nextRunTimes[EmailFrequency.Month] < DateTime.Now)
					{
						_logger.Info("Triggerred: " + EmailFrequency.Month.ToString());
						ProcessEmails(mailNotifyConfig);
					}
					if ((EmailFrequency)mailNotifyConfig.Frequency == EmailFrequency.ThreeMonth && nextRunTimes[EmailFrequency.ThreeMonth] < DateTime.Now)
					{
						_logger.Info("Triggerred: " + EmailFrequency.ThreeMonth.ToString());
						ProcessEmails(mailNotifyConfig);
					}
					if ((EmailFrequency)mailNotifyConfig.Frequency == EmailFrequency.SixMonth && nextRunTimes[EmailFrequency.SixMonth] < DateTime.Now)
					{
						_logger.Info("Triggerred: " + EmailFrequency.Day.ToString());
						ProcessEmails(mailNotifyConfig);
					}
					if ((EmailFrequency)mailNotifyConfig.Frequency == EmailFrequency.Year && nextRunTimes[EmailFrequency.Year] < DateTime.Now)
					{
						_logger.Info("Triggerred: " + EmailFrequency.Year.ToString());
						ProcessEmails(mailNotifyConfig);
					}

				}
			}
			catch(Exception ex)
			{
				_logger.Error("This error occurred while triggering emails: " + ex);
				throw ex;
			}
			
		}

		public void TriggerFormulaPatch(DateTime startTime, DateTime endTime, int dataPatchCycleMinutes)
		{
			var calcFrequencies =new  List<int>();

			foreach (var calcFrequency in calcFrequencies)
			{
				var tempStartTime = startTime;

				var tempEndTime = endTime;

				_logger.Info("Patch started from : " + startTime + "to " + endTime);

				try
				{
					while (tempStartTime <= tempEndTime)
					{
						//if ((EmailFrequency)calcFrequency.Enum == EmailFrequency.Day && tempStartTime < DateTime.Now && tempStartTime.Equals(DateTimeHelper.GetDailyThreshold(tempStartTime)))
						//{
						//    ProcessFormulaPatch(EmailFrequency.Day, tempStartTime);
						//    _logger.Info("Patched: " + EmailFrequency.Day.ToString());
						//}

						//if ((EmailFrequency)calcFrequency.Enum == EmailFrequency.Month && tempStartTime < DateTime.Now && tempStartTime.Equals(DateTimeHelper.GetMonthlyThreshold(tempStartTime)))
						//{
						//    ProcessFormulaPatch(EmailFrequency.Month, tempStartTime);
						//    _logger.Info("Patched: " + EmailFrequency.Month.ToString());
						//}

						//if ((EmailFrequency)calcFrequency.Enum == EmailFrequency.Year && tempStartTime < DateTime.Now && DateTime.Equals(tempStartTime, DateTimeHelper.GetMonthlyThreshold(tempStartTime)))
						//{
						//    ProcessFormulaPatch(EmailFrequency.Year, tempStartTime);
						//    _logger.Info("Patched: " + EmailFrequency.Year.ToString());
						//}

						//_logger.Info("Patched data for date : " + tempStartTime);
						//tempStartTime = tempStartTime.AddMinutes(dataPatchCycleMinutes);
					}
				}
				catch (Exception ex)
				{
					_logger.Error("An unexpected error occurred in executing TriggerFormulaPatch" + ex);
				}
			}
		}

		private void ProcessEmails(Core.Classes.MailNotifyConfig mailNotifyConfig)
		{
			_emailJob.Process(mailNotifyConfig);
			Global.UpdateNextRunTime((EmailFrequency)mailNotifyConfig.Frequency);
		}
	}
}
