namespace Noobot.Examples.Dotnet
{
    using System;
    using Common.Logging;
    using Core;
    using Core.Configuration;
    using Core.DependencyResolution;
    using Configuration;
    
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

        public void Start(ILog log)
        {
            IContainerFactory containerFactory = new ContainerFactory(_configuration, _configReader, log);
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