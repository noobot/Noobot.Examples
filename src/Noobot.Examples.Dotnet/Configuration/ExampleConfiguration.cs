using Noobot.Core.Configuration;

namespace Noobot.Examples.Dotnet.Configuration
{
    using Noobot.Toolbox.Middleware;
    
    public class ExampleConfiguration : ConfigurationBase
    {
        public ExampleConfiguration()
        {
            UseMiddleware<WelcomeMiddleware>();
        }
    }
}