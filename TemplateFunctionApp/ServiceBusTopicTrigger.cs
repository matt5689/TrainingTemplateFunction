using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace TemplateFunctionApp
{
    public static class ServiceBusTopicTrigger
    {
        [FunctionName("ServiceBusTopicTrigger")]
        public static void Run(
            [ServiceBusTrigger("trainingservbus5601topic", "trainingservbus5601topicsubscription", Connection = "ServiceBusConnectionString")]string mySbMsg, 
            ILogger log)
        {
            log.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
