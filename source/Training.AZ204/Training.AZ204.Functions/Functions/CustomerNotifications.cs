using System;
using System.Linq;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Training.AZ204.WebSIte.Context;

namespace Training.AZ204.Functions.Functions
{
    public static class CustomerNotifications
    {
        [FunctionName("CustomerNotifications")]
        public static void Run([TimerTrigger("0 */5 * * * *"
            
                        #if DEBUG
            , RunOnStartup=true 
            #endif

            )]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");

            MiniInvoiceContext context = new MiniInvoiceContext();

            var customers = context.Customers.OrderBy(m => m.Name);

            foreach (var customer in customers)
            {
                log.LogInformation(customer.Name);

            }

        }
    }
}
