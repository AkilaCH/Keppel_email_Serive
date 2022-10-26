using System;
using System.Threading;
using System.Threading.Tasks;
using Azbil.Billing.Service.Helpers;
using Azbil.Billing.Logging;
using Azbil.Billing.Logging.Interfaces;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace WorkerService1
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _workerServiceLogger;

        private ILogManager _logger;

        public Worker(ILogger<Worker> logger)
        {
            _workerServiceLogger = logger;
            _logger = new NlogWrapper(FileTargetLogger.GetFileTargets());
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.Info("Starting Email Service at: " + DateTimeOffset.Now);

            JobScheduler.Start();

            return base.StartAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _workerServiceLogger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
