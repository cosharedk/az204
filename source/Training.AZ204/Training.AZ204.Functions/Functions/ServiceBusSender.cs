using System;
using Azure.Messaging.ServiceBus;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Training.AZ204.Functions.Functions
{
    public static class ServiceBusSenderFunction
    {
        [FunctionName("ServiceBusSender")]
        public static void Run([TimerTrigger("0 */10 * * * *")]TimerInfo myTimer, ILogger log)
        {

            //Sends information to servicebus quqye
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            //Sends to servicebus

            string connectionString = System.Environment.GetEnvironmentVariable("ServiceBusConnectionString");
            string topicName = "orders";

            ServiceBusClient serviceBusClient = new ServiceBusClient(connectionString);

            ServiceBusSender serviceBusSender = serviceBusClient.CreateSender(topicName);

            serviceBusSender.SendMessageAsync(new ServiceBusMessage(DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss"))).GetAwaiter().GetResult();

            log.LogInformation("Time sent to ServiceBusQueue");



        }
    }
}
