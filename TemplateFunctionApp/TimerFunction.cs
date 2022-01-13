using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace TemplateFunctionApp
{
    public static class TimerFunction
    {
        [FunctionName("TimerFunction")]
        public static void Run([TimerTrigger("*/5 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            log.LogError("This is an General Error, your favorite!");

            throw new Exception("Another Genearl Error!");
        }
    }
}
