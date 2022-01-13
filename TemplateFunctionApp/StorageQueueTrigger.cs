using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace TemplateFunctionApp
{
    public static class StorageQueueTrigger
    {
        [FunctionName("StorageQueueTrigger")]
        public static void Run([QueueTrigger("storagequeue", Connection = "StorageQueueConnectionString")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
