using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace TemplateFunctionApp
{
    public class ServiceBusQueueTrigger
    {
        [FunctionName("ServiceBusQueueTrigger")]
        public async Task Run([ServiceBusTrigger("trainingservbus5601queue", Connection = "ServiceBusConnectionString")]string myQueueItem,
            [ServiceBus("trainingservbus5601queue", Connection = "ServiceBusConnectionString")] IAsyncCollector<string> serviceBusReturn,
            ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");

            await serviceBusReturn.AddAsync("Item1");
            await serviceBusReturn.AddAsync("Item2");
        }
    }
}
