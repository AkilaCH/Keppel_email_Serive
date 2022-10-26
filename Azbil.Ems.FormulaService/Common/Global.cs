using Azbil.Billing.Service.Helpers;
using Azbil.Billing.Util.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Azbil.Billing.Service.Common
{
    public class Global
    {
        public static List<Azbil.Billing.Core.Classes.MailNotifyConfig> MailNotifyConfigs { get; set; }

        public static Dictionary<EmailFrequency, DateTime> NextRunTimes { get; set; }

        public static Core.Classes.EmailConfig EmailConfig {get; set;}

        public static DateTime ConfiguredDate {get; set;}
        
        public static int EmailSendDay {get; set;}       

        public static void UpdateNextRunTime(EmailFrequency frequency)
        {
            switch (frequency)
            {
                case EmailFrequency.Day:
                    NextRunTimes[EmailFrequency.Day] = NextRunTimes[EmailFrequency.Day].AddDays(1);
                    break;

                case EmailFrequency.Week:
                    NextRunTimes[EmailFrequency.Week] = NextRunTimes[EmailFrequency.Week].AddDays(7);
                    break;

                case EmailFrequency.Month:
                    NextRunTimes[EmailFrequency.Month] = NextRunTimes[EmailFrequency.Month].AddMonths(1);
                    break;

                case EmailFrequency.ThreeMonth:
                    NextRunTimes[EmailFrequency.ThreeMonth] = NextRunTimes[EmailFrequency.ThreeMonth].AddMonths(3);
                    break;

                case EmailFrequency.SixMonth:
                    NextRunTimes[EmailFrequency.SixMonth] = NextRunTimes[EmailFrequency.SixMonth].AddMonths(6);
                    break;

                case EmailFrequency.Year:
                    NextRunTimes[EmailFrequency.Year] = NextRunTimes[EmailFrequency.Year].AddYears(1);
                    break;
            }
        }

        public static void InitiateNextRunTimes()
        {
            NextRunTimes = new Dictionary<EmailFrequency, DateTime>();

            NextRunTimes.Add(EmailFrequency.Day, EmailHelper.GetScheduledTime(EmailFrequency.Day));

            NextRunTimes.Add(EmailFrequency.Week, EmailHelper.GetScheduledTime(EmailFrequency.Week));

            NextRunTimes.Add(EmailFrequency.Month, EmailHelper.GetScheduledTime(EmailFrequency.Month));

            NextRunTimes.Add(EmailFrequency.ThreeMonth, EmailHelper.GetScheduledTime(EmailFrequency.ThreeMonth));

            NextRunTimes.Add(EmailFrequency.SixMonth, EmailHelper.GetScheduledTime(EmailFrequency.SixMonth));

            NextRunTimes.Add(EmailFrequency.Year, EmailHelper.GetScheduledTime(EmailFrequency.Year));
        }

    }
}
