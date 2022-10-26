using Azbil.Billing.Service.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Azbil.Billing.Util.Enum;

namespace Azbil.Billing.Service.Helpers
{
    public static class EmailHelper
    {
        public static DateTime GetInitialScheduledTime()
        {
            var minFrequency = Global.MailNotifyConfigs?.Find(a => a.Frequency == Global.MailNotifyConfigs.Min(a => a.Frequency));

            return minFrequency != null ? GetScheduledTime((EmailFrequency)minFrequency.Frequency) : DateTime.Now;
        }

        public static DateTime GetScheduledTime(EmailFrequency frequency)
        {
            DateTime startTime;
            var now = DateTime.Now;
            var configuredDateTime = Global.ConfiguredDate;//new DateTime(2022, 2, 8);
            switch (frequency)
            {
                case EmailFrequency.Day:

                    startTime = Util.Common.RoundUp(DateTime.Now, TimeSpan.FromDays(1));
                    break;

                case EmailFrequency.Week:
                    startTime = GetNextWeekday(DateTime.Now, (DayOfWeek)Global.EmailSendDay);
                    break;

                case EmailFrequency.Month:
                    startTime = new DateTime(now.AddMonths(1).Year, now.AddMonths(1).Month, 1, 0, 0, 0);
                    break;

                case EmailFrequency.ThreeMonth:
                    //startTime = Util.Common.RoundUp(DateTime.Now, TimeSpan.FromMinutes(5));
                    startTime = new DateTime(configuredDateTime.AddMonths(3).Year, now.AddMonths(2).Month, 1, 0, 0, 0);
                    break;

                case EmailFrequency.SixMonth:
                    //startTime = Util.Common.RoundUp(DateTime.Now, TimeSpan.FromMinutes(5));
                    startTime = new DateTime(configuredDateTime.AddMonths(6).Year, now.AddMonths(5).Month, 1, 0, 0, 0);
                    break;

                case EmailFrequency.Year:
                    //startTime = new DateTime(now.AddYearSs(1).Year, 1, 1, 0, 0, 0);
                    startTime = new DateTime(configuredDateTime.AddMonths(12).Year, now.AddMonths(11).Month, 1, 0, 0, 0);
                    break;

                default:
                    startTime = now.AddMinutes(1);
                    break;
            }

            return startTime;
        }

        public static DateTime GetNextWeekday(DateTime start, DayOfWeek day)
        {
            // The (... + 7) % 7 ensures we end up with a value in the range [0, 6]
            int daysToAdd = ((int)day - (int)start.DayOfWeek + 7) % 7;
            var startDate = start.AddDays(daysToAdd);
            var date = new DateTime(startDate.Year, startDate.Month, startDate.Day, 0, 0, 0);
            return date;        }

        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}
