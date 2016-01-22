using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Noobot.Examples.Web.Logging
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

        public void Log(string data)
        {
            lock (_lock)
            {
                Console.WriteLine(data);
                Debug.WriteLine(data);
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