using System;
using System.IO;
using System.Web.Mvc;
using Microsoft.Owin;
using Noobot.Examples.Web.DependencyResolution;
using Owin;
using StructureMap;

[assembly: OwinStartupAttribute(typeof(Noobot.Examples.Web.Startup))]
namespace Noobot.Examples.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);

            IContainer container = IoC.Initialize();
            DependencyResolver.SetResolver(new StructureMapDependencyScope(container));
        }
    }
}
