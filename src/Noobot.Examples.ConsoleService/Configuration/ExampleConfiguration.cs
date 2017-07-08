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
            UseMiddleware<CalculatorMiddleware>();
            UseMiddleware<FlickrMiddleware>();
            UseMiddleware<ScheduleMiddleware>();

            UsePlugin<JsonStoragePlugin>();
            UsePlugin<SchedulePlugin>();
        }
    }
}