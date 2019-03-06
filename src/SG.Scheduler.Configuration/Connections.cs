using System;

namespace SG.Scheduler.Configuration
{
    /// <summary>
    /// 数据库连接配置。
    /// </summary>
    public class Connections
    {
        /// <summary>
        /// REDIS服务器地址。
        /// </summary>
        public String Redis { get; set; }
        /// <summary>
        /// 游戏日志服务器地址。
        /// </summary>
        public String GameLogServer { get; set; }
        /// <summary>
        /// 游戏业务服务器地址。
        /// </summary>
        public String GameServer { get; set; }
        /// <summary>
        /// 账号服务器地址。
        /// </summary>
        public String AccountServer { get; set; }
        /// <summary>
        /// 资金交易服务器地址。
        /// </summary>
        public String TransactionServer { get; set; }
        /// <summary>
        /// ORLEAN服务器配置数据地址。
        /// </summary>
        public String OrleansEntry { get; set; }
    }
}
