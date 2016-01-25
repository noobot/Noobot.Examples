using System;
using Noobot.Core;
using Noobot.Core.Configuration;
using Noobot.Core.DependencyResolution;
using Noobot.Core.Logging;
using Noobot.Examples.ConsoleService.Configuration;

namespace Noobot.Examples.ConsoleService
{
    public class NoobotHost
    {
        private readonly IConfigReader _configReader;
        private INoobotCore _noobotCore;
        private readonly IConfiguration _configuration;

        public NoobotHost(IConfigReader configReader)
        {
            _configReader = configReader;
            _configuration = new ExampleConfiguration();
        }

        public void Start()
        {
            IContainerFactory containerFactory = new ContainerFactory(_configuration, _configReader, new ConsoleLog());
            INoobotContainer container = containerFactory.CreateContainer();
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
                })
                .Wait();
        }

        public void Stop()
        {
            Console.WriteLine("Disconnecting...");
            _noobotCore?.Disconnect();
        }
    }
}