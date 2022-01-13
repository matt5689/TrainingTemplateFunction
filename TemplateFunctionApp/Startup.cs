using System;
using System.Collections.Generic;
using System.Runtime;
using System.Text;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(TemplateFunctionApp.Startup))]

namespace TemplateFunctionApp
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            GCSettings.LatencyMode = GCLatencyMode.LowLatency;
        }
    }
}
