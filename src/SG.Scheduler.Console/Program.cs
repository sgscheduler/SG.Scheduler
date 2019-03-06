using Microsoft.Extensions.Configuration;
using System;
using SG.Scheduler.Configuration;
using SG.Scheduler.ConfigurationExtensions;
using Microsoft.Extensions.DependencyInjection;
using System.Threading;
using System.Threading.Tasks;

namespace SG.Scheduler.Console
{
    class Program
    {
        [ThreadStatic]
        private static SchedulerConfiguration Configuration;

        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddSchedulerConfig()
                .Build();
            var serviceProvider = new ServiceCollection()
                .ConfigureSchedulerConfig(config)
                .BuildServiceProvider();
            Configuration = serviceProvider.GetSchedulerConfig();

            System.Console.WriteLine();
            System.Console.ReadLine();
        }
    }
}
