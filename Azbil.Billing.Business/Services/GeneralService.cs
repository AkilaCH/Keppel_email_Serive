using Azbil.Billing.Business.Interfaces;
using Azbil.Billing.Core.Interfaces;
using Azbil.Billing.Data;
using Azbil.Billing.Data.Interfaces;
using Azbil.Billing.Entities.Billing;
using Azbil.Billing.Entities.UserManagement;
using Azbil.Billing.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Business.Services
{
    public class GeneralService : IGeneralService
    {
        private readonly IRepository _dbContext;

        private readonly IUmsRepository _umsDbContext;

       public GeneralService (IRepository dbContext, IUmsRepository umsDbContext)
        {
            _dbContext = dbContext;
            _umsDbContext = umsDbContext;
        }

        public List<Core.Classes.MailNotifyConfig> GetMailNotifiConfigs()
        {
            var mailConfigs = new List<Core.Classes.MailNotifyConfig>();

            var mailConfigEntities = _dbContext.Get<Entities.Billing.MailNotifiConfig>(a => a.Status.Equals("Active"));

            foreach (var calcFrequencyEntity in mailConfigEntities)
            {
                var calcFrequency = UtilityExtension.MapModel <Core.Classes.MailNotifyConfig, Entities.Billing.MailNotifiConfig> (calcFrequencyEntity);
               
                mailConfigs.Add(calcFrequency);
            }

            return mailConfigs;
        }

        public Core.Classes.MailNotifyConfig GetTextIdMailNotifiConfig(string textId)
        {
            var mailConfig= new Core.Classes.MailNotifyConfig();

            var mailConfigEntity = _dbContext.GetOne<Entities.Billing.MailNotifiConfig>
                (a => a.Status.Equals("Active") && a.ContextTextId.Equals(textId) );
            
            if(mailConfig != null)
            {
                mailConfig = UtilityExtension.MapModel<Core.Classes.MailNotifyConfig, Entities.Billing.MailNotifiConfig>(mailConfigEntity);
            }

            return mailConfig;
        }

        public List<Core.Classes.User> GetMailReceivers(int mailConfigId)
        {
            var users = new List<Core.Classes.User>();

            var emailUsersEntities = _dbContext.Get<EmailUser>(a => a.MailNotifiConfigId == mailConfigId && a.Status.Equals("Active"));
            
            foreach (var emailUserEntity in emailUsersEntities)
            {
                var userEntity = _umsDbContext.GetOne<User>(a => a.userId == emailUserEntity.UserId && a.userStatus.Equals("Active"));

               users.Add(UtilityExtension.MapModel<Core.Classes.User, Entities.UserManagement.User>(userEntity));
            }

            return users;
        }

        public int UpdateMailNotificationHistory(int userId, IEmailNotification emailNotification)
        {
            var mailNotificationData = new Entities.Billing.MailNotificationHistory();

            mailNotificationData.InsertedDateTime = DateTime.Now;
            mailNotificationData.Subject = emailNotification.MailSubject;
            mailNotificationData.ContextTextId = emailNotification.ContextTextId;
            mailNotificationData.MailBody = emailNotification.MailContentData;
            mailNotificationData.SenderMailAddress = emailNotification.SenderMailAddress;
            mailNotificationData.RecieverMailAddress = string.Join(",", emailNotification.MailReciversAddressList);
            mailNotificationData.InsertedUserId = userId;
            mailNotificationData.Status = emailNotification.MailNotificationStatus;

            if (emailNotification.MailCcRecipientAddressList != null)
            {
                mailNotificationData.CCRecipientAddress = string.Join(",", emailNotification.MailCcRecipientAddressList);
            }

            try
            {
                _dbContext.Create(mailNotificationData);
                _dbContext.Save();

                return mailNotificationData.MailID;
            }

            catch (Exception)
            {
                return 0;
            }

        }
    }
}
