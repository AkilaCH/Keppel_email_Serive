using Azbil.Billing.Business.Interfaces;
using Azbil.Billing.Core.Classes;
using Azbil.Billing.Core.Interfaces;
using Azbil.Billing.Entities.Billing;
using Azbil.Billing.Logging.Interfaces;
using Azbil.Billing.Util.Enum;
using Microsoft.Extensions.Configuration;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Azbil.Billing.Business.Services
{
    public class EmailService : IEmailService
    {
        public int Year { get; set; }

        public int Month { get; set; }

        public int Day { get; set; }

        private IEmailNotification _emailNotification;

        private IGeneralService _generalService;

        private ILogManager _logger;

        public EmailService(IEmailNotification emailNotification, IGeneralService generalService,
             ILogManager logger)
        {

            _emailNotification = emailNotification;
            _generalService = generalService;
            _logger = logger;
        }

        public int SendNotifyAuditlogApproval(Core.Classes.EmailConfig emailConfig, MailNotifyConfig mailNotifyConfig)
        {
            try
            {
                var populateData = notifyAuditlogApprovalTemplateData();

                var receivers = _generalService.GetMailReceivers(mailNotifyConfig.MailConfigId);

                return SendNotifyMail(mailNotifyConfig, populateData, receivers, emailConfig);
            }
            catch(Exception ex)
            {
                _logger.Error("This error occured while preparing email: " + ex);
                throw ex;
            }
           
        }

        private int SendNotifyMail(Core.Classes.MailNotifyConfig mailNotifyConfig,
            Dictionary<string, string> templateData, IList<User> receivers, IEmailConfig emailConfig)
        {
            var savedMailId = 0;
            var emailNotification = new EmailNotification();
            emailNotification.MailHeader = PopulateMailTemplate(mailNotifyConfig.Header, templateData);
            emailNotification.MailBody = PopulateMailTemplate(mailNotifyConfig.MailContentTemplate, templateData);
            emailNotification.MailFooter = PopulateMailTemplate(mailNotifyConfig.Footer, templateData);

            emailNotification.SenderMailAddress = emailConfig.Username;
            emailNotification.SenderMailPassword = emailConfig.Password;
            emailNotification.MailSubject = mailNotifyConfig.Subject;
            emailNotification.ContextTextId = mailNotifyConfig.ContextTextId;
            emailNotification.Host = emailConfig.Host;

            if(receivers != null && receivers.Any())
            {
                emailNotification.MailReciversAddressList = receivers.Select(a => a.UserEmail).ToList();
            }
            emailNotification.MailReciversAddressList = new List<string>();

            int mailDeliveryStatus = SendMail(emailNotification, receivers, emailConfig);

            if (mailDeliveryStatus != (int)EmailStatus.Invalid)
            {
                if (mailDeliveryStatus == (int)EmailStatus.Success)
                {
                    emailNotification.MailNotificationStatus = "Success";
                }
                else if (mailDeliveryStatus == (int)EmailStatus.Failed)
                {
                    emailNotification.MailNotificationStatus = "Failed";
                }

                savedMailId = _generalService.UpdateMailNotificationHistory(0, emailNotification);
            }

            return savedMailId != 0 ? mailDeliveryStatus : savedMailId;
        }


        public int SendMail(IEmailNotification emailNotification, IList<User> receivers, IEmailConfig emailConfig)
        {
            try
            {
                using (MailMessage mailMessage = new MailMessage())
                {
                    mailMessage.From = new MailAddress(emailNotification.SenderMailAddress);
                    mailMessage.Subject = emailNotification.MailSubject;
                    mailMessage.Body = emailNotification.MailContentData = (emailNotification.MailContentData ?? emailNotification.MailHeader + emailNotification.MailBody + emailNotification.MailFooter);
                    mailMessage.IsBodyHtml = true;
                    foreach (var receriver in receivers)
                    {
                        mailMessage.To.Add(new MailAddress(receriver.UserEmail));
                    }

                    if (emailNotification.MailCcRecipientAddressList != null)
                    {
                        foreach (string mailCcRecipient in emailNotification.MailCcRecipientAddressList)
                        {
                            mailMessage.CC.Add(new MailAddress(mailCcRecipient));
                        }
                    }

                    SmtpClient smtp = new SmtpClient();
                    smtp.Host = emailNotification.Host;
                    smtp.EnableSsl = Convert.ToBoolean(emailConfig.EnableSsl);
                    System.Net.NetworkCredential NetworkCred = new System.Net.NetworkCredential();
                    NetworkCred.UserName = emailNotification.SenderMailAddress;
                    NetworkCred.Password = emailNotification.SenderMailPassword;
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = NetworkCred;
                    smtp.Port = int.Parse(emailConfig.Port);

                    try
                    {
                        smtp.Send(mailMessage);
                        return (int)EmailStatus.Success;
                    }
                    catch (SmtpFailedRecipientException ex)
                    {
                        SmtpStatusCode statusCode = ex.StatusCode;

                        if (statusCode == SmtpStatusCode.MailboxBusy ||
                            statusCode == SmtpStatusCode.MailboxUnavailable ||
                            statusCode == SmtpStatusCode.TransactionFailed)
                        {
                            _logger.Error("Mail Sent Failed" + ex);
                            return (int)EmailStatus.Failed;
                        }
                        else
                        {
                            _logger.Error(ex);
                            return (int)EmailStatus.Invalid;
                        }
                    }

                }
            }
            
            catch (Exception ex)
            {
                _logger.Error("This error occured while sending email: " + ex);
                return (int)EmailStatus.Invalid;
            }

        }

        public string PopulateMailTemplate(string templateText, Dictionary<string, string> convertedData)
        {
            foreach (KeyValuePair<string, string> entry in convertedData)
            {
                if (templateText.Contains("{" + entry.Key + "}"))
                {
                    templateText = templateText.Replace("{" + entry.Key + "}", entry.Value);
                }
            }

            return templateText;
        }

        public Dictionary<string, string> notifyAuditlogApprovalTemplateData()
        {
            var populateData = new Dictionary<string, string>();
            DateTime monthname = new DateTime(this.Year, this.Month, 1);
            populateData.Add("Year", validateKeyValue(this.Year.ToString()));
            populateData.Add("Month", validateKeyValue(monthname.ToString("MMMM")));
            populateData.Add("Day", validateKeyValue(this.Day.ToString()));
            return populateData;
        }

        private string validateKeyValue(string value) => value ?? "-";
    }
}
