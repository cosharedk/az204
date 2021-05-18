using System;
using Azure.Messaging.ServiceBus;
using Azure.Storage.Queues;
using Microsoft.Ajax.Utilities;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Training.AZ204.WebSIte.Models;

namespace Training.AZ204.Functions
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([TimerTrigger("0 */10 * * * *")]TimerInfo myTimer, ILogger log)
        {

            //Kører hvert femte sekund og poster en besked til køen!
            QueueClient queueClient = new QueueClient(System.Environment.GetEnvironmentVariable("StorageConnectionString"), "thequeue");

            queueClient.CreateIfNotExists();

            Customer customer = new Customer()
            {
                Name = "Peter Hansen",
                Email = "ph@whatever.com"
            };

            


            queueClient.SendMessage($"Klokken er {0}, DateTime.UtcNow.ToLongTimeString()");
        }
    }
}
