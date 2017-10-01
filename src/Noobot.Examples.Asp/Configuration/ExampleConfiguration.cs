using Noobot.Core.Configuration;
using Noobot.Toolbox.Middleware;

namespace Noobot.Examples.Asp.Configuration
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