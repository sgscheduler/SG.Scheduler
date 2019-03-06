using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Options;
using SG.Scheduler.Configuration;
using System;
using System.IO;

namespace SG.Scheduler.ConfigurationExtensions
{
    /// <summary>
    /// Scheduler配置扩展方法。
    /// </summary>
    public static class SchedulerConfigurationExtensions
    {
        /// <summary>
        /// 添加Scheduler配置。
        /// </summary>
        /// <param name="builder">实现了 IConfigurationBuilder 接口的实例。</param>
        /// <param name="jsonFile">JSON配置文件名称（含扩展名）。</param>
        /// <param name="reloadOnChange">是否在文件改变后重新加载。</param>
        /// <returns>实现了 IConfigurationBuilder 接口的实例。</returns>
        public static IConfigurationBuilder AddSchedulerConfig(this IConfigurationBuilder builder, Boolean reloadOnChange = false)
        {
            return builder
                .SetBasePath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Properties"))
                .AddJsonFile($"appsettings.json", true, reloadOnChange);
        }

        /// <summary>
        /// 获取一个Scheduler配置。每一次调用都将创建新的实例。
        /// </summary>
        /// <param name="config">实现了 IConfigurationRoot 接口的配置根节点的实例。</param>
        /// <returns>Scheduler配置。</returns>
        public static SchedulerConfiguration GetSchedulerConfig(this IConfigurationRoot config)
        {
            return config.Get<SchedulerConfiguration>();
        }

        /// <summary>
        /// 使用"Options模式"注入Scheduler配置。
        /// </summary>
        /// <param name="serviceCollection">实现了 IServiceCollection 接口的实例。</param>
        /// <param name="config">实现了 IConfigurationRoot 接口的配置根节点的实例。</param>
        /// <returns>实现了 IServiceCollection 接口的实例。</returns>
        public static IServiceCollection ConfigureSchedulerConfig(this IServiceCollection serviceCollection, IConfigurationRoot config)
        {
            return serviceCollection
                .AddOptions()
                .Configure<SchedulerConfiguration>(config);
        }

        /// <summary>
        /// 获取Scheduler配置。以单例的方式返回实例。
        /// </summary>
        /// <param name="serviceProvider">实现了 IServiceProvider 接口的实例。</param>
        /// <returns>Scheduler配置。</returns>
        public static SchedulerConfiguration GetSchedulerConfig(this IServiceProvider serviceProvider)
        {
            return serviceProvider.GetService<IOptions<SchedulerConfiguration>>()
                .Value;
        }
    }
}
