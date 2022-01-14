using IsaProject.Data;
using IsaProject.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using IsaProject.Models.Entities;
using IsaProject.Models.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace IsaProject.Services
{
    public class PenaltyDeleteService : CronJobService
    {
        private readonly ILogger<PenaltyAddService> _logger;
        private readonly ApplicationDbContext _context;
        private readonly ISchedulerService _schedulerService;

        public PenaltyDeleteService(IScheduleConfig<PenaltyAddService> config, ILogger<PenaltyAddService> logger, IServiceScopeFactory factory)
        : base(config.CronExpression, config.TimeZoneInfo)
        {
            _logger = logger;
            _schedulerService = factory.CreateScope().ServiceProvider.GetRequiredService<ISchedulerService>();
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("CronJob  starts.");
            return base.StartAsync(cancellationToken);
        }

        public override Task DoWork(CancellationToken cancellationToken)
        {
            _logger.LogInformation($"{DateTime.Now:hh:mm:ss} CronJob  is working.");


            _schedulerService.DeletePenalty();

            return Task.CompletedTask;
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("CronJob  is stopping.");
            return base.StopAsync(cancellationToken);
        }
    }
}
