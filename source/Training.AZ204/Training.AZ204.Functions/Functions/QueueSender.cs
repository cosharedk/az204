using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Azure.Storage.Queues;
using Training.AZ204.WebSIte.Models;
using System.Text.Json;
using System.Text;

namespace Training.AZ204.Functions.Functions
{
    public static class QueueSender
    {
        [FunctionName("QueueSender")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;


            QueueClient queueClient = new QueueClient(System.Environment.GetEnvironmentVariable("StorageConnectionString"), "customers", new QueueClientOptions
            {
                MessageEncoding = QueueMessageEncoding.Base64
            });

            queueClient.CreateIfNotExists();

            Customer customer = new Customer()
            {
                Name = name,
                Email = $"{name}@whatever.org"
            };

            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };


            string jsonString = System.Text.Json.JsonSerializer.Serialize<Customer>(customer,options);


            byte[] buffer=Encoding.Unicode.GetBytes(jsonString);

            queueClient.SendMessage(Convert.ToBase64String(buffer));

            string responseMessage = string.IsNullOrEmpty(name)
                ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
                : $"Hello, {name}. This HTTP triggered function executed successfully.";

            return new OkObjectResult(responseMessage);
        }
    }
}
