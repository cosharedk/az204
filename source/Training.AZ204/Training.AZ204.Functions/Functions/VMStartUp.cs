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

            log.LogInformation($"VMStartUp initiated at: {DateTime.Now}");

            //Initialize variables for function
            string tenantId = System.Environment.GetEnvironmentVariable("TenantId");
            string clientId = System.Environment.GetEnvironmentVariable("VMAdminClientId");
            string clientSecret = System.Environment.GetEnvironmentVariable("VMAdminClientSecret");



            



        }
    }
}
