using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Noobot.Examples.Web.Startup))]
namespace Noobot.Examples.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
