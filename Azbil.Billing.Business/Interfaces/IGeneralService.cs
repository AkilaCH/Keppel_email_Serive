using Azbil.Billing.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Business.Interfaces
{
    public interface IGeneralService
    {
        List<Core.Classes.MailNotifyConfig> GetMailNotifiConfigs();

        Core.Classes.MailNotifyConfig GetTextIdMailNotifiConfig(string textId);

        List<Core.Classes.User> GetMailReceivers(int mailConfigId);

        int UpdateMailNotificationHistory(int userId, IEmailNotification emailNotification);
    }
}
