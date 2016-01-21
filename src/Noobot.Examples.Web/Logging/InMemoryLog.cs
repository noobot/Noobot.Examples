using System.Collections.Generic;

namespace Noobot.Examples.Web.Logging
{
    public class MemoryLog : IMemoryLog
    {
        private readonly List<string> _log = new List<string>();
        private readonly object _lock = new object();

        public void Log(string data)
        {
            lock (_lock)
            {
                _log.Add(data);
            }
        }

        public string[] FullLog()
        {
            lock (_lock)
            {
                return _log.ToArray();
            }
        }
    }
}