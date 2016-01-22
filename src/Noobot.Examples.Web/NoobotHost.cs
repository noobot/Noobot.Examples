using System;
using Noobot.Core;
using Noobot.Core.DependencyResolution;
using Noobot.Examples.Web.Logging;

namespace Noobot.Examples.Web
{
    public class NoobotHost : INoobotHost
    {
        private readonly IContainerFactory _containerFactory;
        private readonly IMemoryLog _memoryLog;
        private INoobotCore _noobotCore;

        public NoobotHost(IContainerFactory containerFactory, IMemoryLog memoryLog)
        {
            _containerFactory = containerFactory;
            _memoryLog = memoryLog;
        }

        public INoobotHost Start()
        {
            INoobotContainer container = _containerFactory.CreateContainer();
            _noobotCore = container.GetNoobotCore();

            Console.WriteLine("Connecting...");
            _noobotCore
                .Connect()
                .ContinueWith(task =>
                {
                    if (!task.IsCompleted || task.IsFaulted)
                    {
                        Console.WriteLine($"Error connecting to Slack: {task.Exception}");
                    }
                });

            return this;
        }

        public string[] GetLog()
        {
            return _memoryLog?.FullLog() ?? new string[0];
        }
    }
}