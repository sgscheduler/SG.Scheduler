using System;
using System.Collections.Generic;
using System.Text;

namespace SG.Scheduler.Configuration
{
    /// <summary>
    /// 应用程序配置。
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// 重试次数。
        /// </summary>
        public Int32 RetryCount { get; set; }
        /// <summary>
        /// 重试间隔（单位毫秒）。
        /// </summary>
        public Int32 RetryInterval { get; set; }
        /// <summary>
        /// 组织编码。
        /// </summary>
        public String OrganizationCode { get; set; }
    }
}
