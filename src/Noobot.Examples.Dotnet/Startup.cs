using System;
using Noobot.Examples.Dotnet.Configuration;
using Common.Logging;
using Common.Logging.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Noobot.Examples.Dotnet.Logging;

namespace Noobot.Examples.Dotnet
{
    public class Startup
    {
        public static IConfigurationRoot Configuration { get; set; }

        public Startup(IHostingEnvironment env)
        {
            // Set up configuration sources.
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
            
            var logConfiguration = new LogConfiguration();
            Configuration.GetSection("LogConfiguration").Bind(logConfiguration);
            LogManager.Configure(logConfiguration);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IMemoryLog, MemoryLog>();
        }
        
        public void Configure(IApplicationBuilder app, IApplicationLifetime applicationLifetime, IHostingEnvironment env, IMemoryLog log)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            
            var noobHost = new NoobotHost(new DotnetCoreConfigReader(Configuration.GetSection("Bot")));
            applicationLifetime.ApplicationStarted.Register(() => noobHost.Start(log));
            applicationLifetime.ApplicationStopping.Register(noobHost.Stop);

            app.Run(async context =>
            {
                await context.Response.WriteAsync(string.Join(Environment.NewLine, log.FullLog()));
            });
        }
    }
}