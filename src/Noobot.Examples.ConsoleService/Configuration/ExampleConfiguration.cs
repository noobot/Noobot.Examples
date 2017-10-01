using Noobot.Core.Configuration;
using Noobot.Toolbox.Middleware;
using Noobot.Toolbox.Plugins;

namespace Noobot.Examples.ConsoleService.Configuration
{
    public class ExampleConfiguration : ConfigurationBase
    {
        public ExampleConfiguration()
        {
            UseMiddleware<WelcomeMiddleware>();
            UseMiddleware<JokeMiddleware>();
            UseMiddleware<ScheduleMiddleware>();

            UsePlugin<JsonStoragePlugin>();
            UsePlugin<SchedulePlugin>();
        }
    }
}