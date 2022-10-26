using Azbil.Billing.Business.Interfaces;
using Azbil.Billing.Business.Services;
using Azbil.Billing.Core.Classes;
using Azbil.Billing.Core.Interfaces;
using Azbil.Billing.Data;
using Azbil.Billing.Data.Interfaces;
using Azbil.Billing.Logging;
using Azbil.Billing.Logging.Interfaces;
using Azbil.Billing.Service.Helpers;
using Azbil.Billing.Service.Interfaces;
using Microsoft.Extensions.Configuration;
using Ninject;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Azbil.Billing.Service.Bindings
{
    public class ServiceBinding : NinjectModule
    {
        public override void Load()
        {
            var Configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

             var masterDataBase = Configuration.GetSection("ConnectionStrings")["MasterDatabase"];
             var umsDatabase = Configuration.GetSection("ConnectionStrings")["UmsDatabase"];

            Bind<DbContext>().To<BillingContext>().InTransientScope().WithConstructorArgument("connectionString", masterDataBase);
            Bind<DbContext>().To<UMSContext>().InTransientScope().WithConstructorArgument("connectionString", umsDatabase);
            
            Bind<IConfiguration>().ToMethod(a =>
            {
                var config = new ConfigurationBuilder();
                config.AddJsonFile("appsettings.json");
                return config.Build();
            });
            Bind<IEmailNotification>().To<EmailNotification>().InTransientScope();
            Bind<ILogManager>().To<NlogWrapper>().WithConstructorArgument("fileTargets", FileTargetLogger.GetFileTargets());

            Bind<IRepository>().To(typeof(Repository<DbContext>)).InTransientScope();

            var masterDbContext = new Repository<BillingContext>(new BillingContext(masterDataBase));
            var umsDbContext = new Repository<UMSContext>(new UMSContext(umsDatabase));
            Bind<IGeneralService>().To<GeneralService>().InTransientScope().WithConstructorArgument("dbContext", masterDbContext).
                WithConstructorArgument("umsDbContext", umsDbContext) ;

            Bind<IEmailService>().To<EmailService>().InTransientScope();
            Bind<IEmailJob>().To<EmailJob>().InTransientScope();
        }
    }
}
