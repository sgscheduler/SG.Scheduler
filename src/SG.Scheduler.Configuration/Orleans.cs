using System;

namespace SG.Scheduler.Configuration
{
    /// <summary>
    /// 奥尔良框架配置。
    /// </summary>
    public class Orleans
    {
        /// <summary>
        /// 服务器Id。
        /// </summary>
        public String ServiceId { get; set; }
        /// <summary>
        /// 集群Id。
        /// </summary>
        public String ClusterId { get; set; }
        /// <summary>
        /// 服务器端口号。
        /// </summary>
        public Int32 SiloPort { get; set; }
        /// <summary>
        /// 网关端口号。
        /// </summary>
        public Int32 GatewayPort { get; set; }
        /// <summary>
        /// 数据提供器类型。
        /// </summary>
        public String Invariant { get; set; }
    }
}
