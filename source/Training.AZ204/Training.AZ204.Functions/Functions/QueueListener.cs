using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Training.AZ204.Functions.Functions
{
    public static class QueueListener
    {
        [FunctionName("QueueListener")]
        public static void Run([QueueTrigger("customers", Connection = "StorageConnectionString")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");


        }
    }
}
