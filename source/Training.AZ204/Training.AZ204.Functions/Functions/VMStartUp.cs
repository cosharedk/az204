using System;
using Microsoft.Azure.Management.Compute.Fluent;
using Microsoft.Azure.Management.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.Azure.Management.ResourceManager.Fluent.Authentication;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Training.AZ204.Functions.Functions
{
    public static class VMStartUp
    {
        [FunctionName("VMStartUp")]
        public static void Run([TimerTrigger("0 0 8 * * *"
            
            //Nedenstående sørger for at funktionen starter ved startup, når der bebugges, så man ikke skal vente til klokken 8 :-)

            #if DEBUG
            , RunOnStartup=true 
            #endif

            )]TimerInfo myTimer, ILogger log)
        {

            log.LogInformation($"VMStartUp initiated at: {DateTime.Now}");

            //Initialiser variablen - og sørg for at give App'en rettigheder til den eller de resourcegrupper, den skal anvendes i
            string tenantId = System.Environment.GetEnvironmentVariable("TenantId");
            string clientId = System.Environment.GetEnvironmentVariable("VMAdminClientId");
            string clientSecret = System.Environment.GetEnvironmentVariable("VMAdminClientSecret");

            var context = SdkContext.AzureCredentialsFactory.FromServicePrincipal(clientId, clientSecret, tenantId, AzureEnvironment.AzureGlobalCloud);

            var azure = Azure.Configure()
                .WithLogLevel(HttpLoggingDelegatingHandler.Level.Basic)
                .Authenticate(context)
                .WithDefaultSubscription();

            var vms = azure.VirtualMachines.List();

            foreach (var vm in vms)
            {
                if (vm.PowerState == PowerState.Stopped || vm.PowerState == PowerState.Deallocated)
                {
                    log.LogInformation($"Starting VM {vm.Name} in resource group {vm.ResourceGroupName}");
                    vm.Start();
                }
                else
                {
                    log.LogInformation($"{vm.Name} is currently not in running-state");
                }
            }

            log.LogInformation($"VMStartUp ended at: {DateTime.Now}");

        }
    }
}
