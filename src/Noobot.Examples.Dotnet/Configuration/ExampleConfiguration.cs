using Noobot.Core.Configuration;
using Noobot.Toolbox.Middleware;

namespace Noobot.Examples.Dotnet.Configuration
{
    public class ExampleConfiguration : ConfigurationBase
    {
        public ExampleConfiguration()
        {
            UseMiddleware<WelcomeMiddleware>();
            UseMiddleware<JokeMiddleware>();
        }
    }
}