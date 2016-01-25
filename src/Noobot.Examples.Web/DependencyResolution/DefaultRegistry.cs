// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DefaultRegistry.cs" company="Web Advanced">
// Copyright 2012 Web Advanced (www.webadvanced.com)
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0

// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using Noobot.Core.Configuration;
using Noobot.Core.DependencyResolution;
using Noobot.Core.Logging;
using Noobot.Examples.Web.Configuration;
using Noobot.Examples.Web.Logging;
using StructureMap;

namespace Noobot.Examples.Web.DependencyResolution {
    using StructureMap.Configuration.DSL;
    using StructureMap.Graph;
	
    public class DefaultRegistry : Registry {
        #region Constructors and Destructors

        public DefaultRegistry() {
            Scan(
                scan => {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
					scan.With(new ControllerConvention());
                });

            var log = new MemoryLog();
            For<ILog>().Use(log);
            For<IMemoryLog>().Use(log);

            For<IConfigReader>()
                .Use<ExampleJsonConfigReader>()
                .Singleton();

            For<IConfiguration>()
                .Use<ExampleConfiguration>();

            For<INoobotHost>()
                .Use(x => x.GetInstance<NoobotHost>().Start())
                .Singleton();

            For<IContainerFactory>()
                .Use(x => new ContainerFactory(x.GetInstance<IConfiguration>(), x.GetInstance<IConfigReader>(), x.GetInstance<ILog>()));
        }

        #endregion
    }
}