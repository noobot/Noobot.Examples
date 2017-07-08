using Noobot.Core.Configuration;
using Noobot.Toolbox.Middleware;

namespace Noobot.Examples.Web.Configuration
{
    public class ExampleConfiguration : ConfigurationBase
    {
        public ExampleConfiguration()
        {
            UseMiddleware<WelcomeMiddleware>();
            UseMiddleware<JokeMiddleware>();
            UseMiddleware<CalculatorMiddleware>();
            UseMiddleware<FlickrMiddleware>();

            UsePlugin<Toolbox.Plugins.JsonStoragePlugin>();
        }
    }
}