using Microsoft.Extensions.Logging;
using System;

namespace SG.Scheduler.Logging.NLog
{
    public class NLoggerProvider : ILoggerProvider
    {
        public ILogger CreateLogger(String categoryName)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
