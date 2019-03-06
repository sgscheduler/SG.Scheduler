namespace SG.Scheduler.Configuration
{
    /// <summary>
    /// 调度器配置。
    /// </summary>
    public class SchedulerConfiguration
    {
        /// <summary>
        /// 与数据库连接有关的配置项。
        /// </summary>
        public Connections Connections { get; set; }
        /// <summary>
        /// 与奥尔良框架有关的配置项。
        /// </summary>
        public Orleans Orleans { get; set; }
        /// <summary>
        /// 应用程序配置项。
        /// </summary>
        public AppSettings AppSettings { get; set; }
    }
}
