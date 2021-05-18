using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Training.AZ204.WebSIte.Context;
using Training.AZ204.WebSIte.Models;

namespace Training.AZ204.Functions.Functions
{
    public static class QueueListener
    {
        [FunctionName("QueueListener")]
        public static void Run([QueueTrigger("customers", Connection = "StorageConnectionString")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");


            Customer customer = System.Text.Json.JsonSerializer.Deserialize<Customer>(myQueueItem);

            MiniInvoiceContext ctx = new MiniInvoiceContext();

            ctx.Customers.Add(customer);


        }
    }
}
