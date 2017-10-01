using System;
using System.Collections.Generic;
using Common.Logging;

namespace Noobot.Examples.Asp.Logging
{
    public class MemoryLog : IMemoryLog
    {
        private readonly List<string> _log;
        private readonly object _lock;

        public MemoryLog()
        {
            _log = new List<string>();
            _lock = new object();
        }

        public string[] FullLog()
        {
            lock (_lock)
            {
                return _log.ToArray();
            }
        }

        public void Trace(object message)
        {
            lock (_lock)
            {
                _log.Add((message ?? "").ToString());
            }
        }

        public void Trace(object message, Exception exception)
        {
            lock (_lock)
            {
                _log.Add((message ?? "").ToString());
            }
        }

        public void TraceFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void TraceFormat(string format, Exception exception, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void TraceFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void TraceFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Trace(Action<FormatMessageHandler> formatMessageCallback)
        {
            throw new NotImplementedException();
        }

        public void Trace(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Trace(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            throw new NotImplementedException();
        }

        public void Trace(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Debug(object message)
        {
            lock (_lock)
            {
                _log.Add((message ?? "").ToString());
            }
        }

        public void Debug(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void DebugFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void DebugFormat(string format, Exception exception, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void DebugFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void DebugFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Debug(Action<FormatMessageHandler> formatMessageCallback)
        {
            throw new NotImplementedException();
        }

        public void Debug(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Debug(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            throw new NotImplementedException();
        }

        public void Debug(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Info(object message)
        {
            lock (_lock)
            {
                _log.Add((message ?? "").ToString());
            }
        }

        public void Info(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(string format, Exception exception, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void InfoFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Info(Action<FormatMessageHandler> formatMessageCallback)
        {
            throw new NotImplementedException();
        }

        public void Info(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Info(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            throw new NotImplementedException();
        }

        public void Info(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Warn(object message)
        {
            lock (_lock)
            {
                _log.Add((message ?? "").ToString());
            }
        }

        public void Warn(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(string format, Exception exception, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void WarnFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Warn(Action<FormatMessageHandler> formatMessageCallback)
        {
            throw new NotImplementedException();
        }

        public void Warn(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Warn(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            throw new NotImplementedException();
        }

        public void Warn(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Error(object message)
        {
            lock (_lock)
            {
                _log.Add((message ?? "").ToString());
            }
        }

        public void Error(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(string format, Exception exception, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void ErrorFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Error(Action<FormatMessageHandler> formatMessageCallback)
        {
            throw new NotImplementedException();
        }

        public void Error(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Error(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            throw new NotImplementedException();
        }

        public void Error(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Fatal(object message)
        {
            lock (_lock)
            {
                _log.Add((message ?? "").ToString());
            }
        }

        public void Fatal(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(string format, Exception exception, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(IFormatProvider formatProvider, string format, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void FatalFormat(IFormatProvider formatProvider, string format, Exception exception, params object[] args)
        {
            throw new NotImplementedException();
        }

        public void Fatal(Action<FormatMessageHandler> formatMessageCallback)
        {
            throw new NotImplementedException();
        }

        public void Fatal(Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Fatal(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback)
        {
            throw new NotImplementedException();
        }

        public void Fatal(IFormatProvider formatProvider, Action<FormatMessageHandler> formatMessageCallback, Exception exception)
        {
            throw new NotImplementedException();
        }

        public bool IsTraceEnabled => true;
        public bool IsDebugEnabled => true;
        public bool IsErrorEnabled => true;
        public bool IsFatalEnabled => true;
        public bool IsInfoEnabled => true;
        public bool IsWarnEnabled => true;
        public IVariablesContext GlobalVariablesContext { get; }
        public IVariablesContext ThreadVariablesContext { get; }
        public INestedVariablesContext NestedThreadVariablesContext { get; }
    }
}