using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Training.AZ204.Functions.Functions
{
    public static class VMStartUp
    {
        [FunctionName("VMStartUp")]
        public static void Run([TimerTrigger("0 0 8 * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");




        }
    }
}
