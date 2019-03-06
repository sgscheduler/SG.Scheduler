using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace SG.Scheduler.Logging.NLog
{
    public class NLogger : ILogger
    {
        #region Constructors

        public NLogger(String name, Func<String, LogLevel, Boolean> filter)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Filter = filter ?? (Func<String, LogLevel, Boolean>)((c, l) => true);
        }

        #endregion

        #region Properties

        public String Name { get; }

        #region Filter

        private Func<String, LogLevel, Boolean> _filer;
        public Func<String, LogLevel, Boolean> Filter
        {
            get => _filer;
            set => _filer = value ?? throw new ArgumentNullException(nameof(value));
        }

        #endregion

        #endregion

        #region ILogger

        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }

        public Boolean IsEnabled(LogLevel logLevel) => Filter(Name, logLevel);

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            if (IsEnabled(logLevel)) return;
            
        }

        #endregion
    }
}
