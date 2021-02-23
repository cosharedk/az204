# Links til AZ 204 - developing Azure Solutions

Her listen over links og værktøjer til AZ-204-kurset, jeg plejer at bruge som guideline  - har du tilføjelser eller kommentarer, er du velkommen til at sende [en mail](mailto:pmn@coshare.dk) - så skal jeg få dem på listen, hvis jeg mener de passer ind!

## Værktøjer
Jeg bruger en del værktøjer i min undervisning, der gør hverdagen lettere - her er installation-guides til de fleste af dem:

- [Visual Studio Community Edition](https://visualstudio.microsoft.com/)
- [Visual Studio Code](https://code.visualstudio.com/)
- [Installer AZ-PowerShell modulet til Azure](https://docs.microsoft.com/en-us/powershell/azure/install-az-ps?view=azps-5.4.0)
- Afinstaller det gamle PowerShell-modul (AzureRM)
- [Get started with Azure CLI](https://docs.microsoft.com/en-us/cli/azure/get-started-with-azure-cli) - hvad skal installeres og hvordan skriver jeg mine første scripts i CLI
- [Azure Storage Explorer](https://azure.microsoft.com/en-us/features/storage-explorer/) - er indbygget i portalen i vore dage, men kan hentes som desktop-progam.
- [Azure Functions Core Tools](https://docs.microsoft.com/en-us/azure/azure-functions/functions-run-local#install-the-azure-functions-core-tools) - core tools til Azure Functions, hvis man skal lave dem i Visual Studio Code

## Certificerings-links
Til de der skal certificeres, bruger jeg følgende links:
- [MeasureUp](https://www.measureup.com) - generator med eksamens-spørgsmål
- [Pluralsight](https://www.pluralsight.com) - videotjeneste med tons-vis af instruktions-videoer om blandt meget andet Azure
- [Examref bog](https://www.amazon.com/AZ-204-Developing-Solutions-Microsoft-Azure/dp/0136798330)

## Module 01: Creating Azure App Service Web Apps

### Links
- [Docker Build: A Beginner’s Guide to Building Docker Images](https://stackify.com/docker-build-a-beginners-guide-to-building-docker-images/)
- [Set up staging environments in Azure App Service](https://docs.microsoft.com/en-us/azure/app-service/deploy-staging-slots)

### Labs
- [Lab: Building a web application on Azure platform as a service offerings](https://github.com/MicrosoftLearning/AZ-204-DevelopingSolutionsforMicrosoftAzure/blob/master/Instructions/Labs/AZ-204_01_lab_ak.md) - Den officielle lab til modul 1

## Module 02: Implement Azure Functions

### Links

- [Create your first function in Azure using Visual Studio](https://docs.microsoft.com/en-us/azure/azure-functions/functions-create-your-first-function-visual-studio) - basal begynder guide til at lave en Azure Function i Visual Studio med C#
- [Develop Azure Functions by using Visual Studio Code](https://docs.microsoft.com/en-us/azure/azure-functions/functions-develop-vs-code?tabs=csharp) - guide 
- [Azure Functions – Time Trigger (CRON) Cheat Sheet](https://arminreiter.com/2017/02/azure-functions-time-trigger-cron-cheat-sheet/) - lidt hjælp til at lave CRON expressions til Timer-baserede functions
- [Azure Functions time zone issue](https://www.serverlessnotes.com/docs/azure-functions-time-zone-issue) - få Azure Functions til at eksekvere i den tidszone, du gerne vil have den til.

### Kodeeksempler
I function-app-projektet i demo-koden findes en del eksempler på Azure-functions i praksis:

- [VMStartUp](../source/Training.AZ204/Training.AZ204.Functions/fimctopms/../Functions/VMStartUp.cs) - starter de virtuelle maskiner i en bestemt resource-gruppe
- VMShutDown - starter og stopper de virtuelle maskiner i en bestemt resource-gruppe
- [BlobTrigger](../source/Training.AZ204/Training.AZ204.Functions/functions/BlobListener.cs) - eksekverer, når der lander en blob i en storage account
- QueueTrigger - eksekverer, når der lander en besked på køen

### Labs
- [Lab: Implementing task processing logic by using Azure Functions
](https://github.com/MicrosoftLearning/AZ-204-DevelopingSolutionsforMicrosoftAzure/blob/master/Instructions/Labs/AZ-204_02_lab_ak.md)

## Module 03: Develop solutions that use blob storage

### Links
- [Quickstart: Azure Blob storage client library v11 for .NET](https://docs.microsoft.com/en-us/azure/storage/blobs/storage-quickstart-blobs-dotnet-legacy) - legacy udgaven af starter guiden - v12 nedenfor bør anvendes i stedet!
- [Quickstart: Azure Blob Storage client library v12 for .NET](https://docs.microsoft.com/en-us/azure/storage/blobs/storage-quickstart-blobs-dotnet) - starter guide med den nye (fra 2020) 
- [Azure Storage Explorer (desktop version)](https://azure.microsoft.com/en-us/features/storage-explorer/)

### Kodeeksempler

- [MVC projekt med list blobs](../source/Training.AZ204/Training.AZ204.WebApp/../Training.AZ204.WebSite/Controllers/BlobController.cs) - et eksempel der lister alle blobs i en container
- [BlobListener](../source/Training.AZ204/Training.AZ204.Functions/functions/BlobListener.cs) - Azure Function der lytter til en container og reagerer

## Module 04: Develop solutions that use Cosmos DB storage

### Links


### Kodeeksempler


## Module 05: Implement IaaS solutions

### Links
- [Quick start templates](https://github.com/Azure/azure-quickstart-templates) - en række ARM-templates klar til brug eller inspiration 

## Module 06: Implement user authentication and authorization

### Kodeeksempler
- Der er et eksempel på oAuth via en app-registrering i [VMStartUp-function-appen](../source/Training.AZ204/Training.AZ204.Functions/Functions/VMStartUp.cs)

### Links

- [Graph Explorer](https://developer.microsoft.com/en-us/graph/graph-explorer) - godt web-interface til at lege med Graph API'et


## Module 07: Implement secure cloud solutions

### Links
- [Tutorial: Use a managed identity to connect Key Vault to an Azure web app in .NET](https://docs.microsoft.com/en-us/azure/key-vault/general/tutorial-net-create-vault-azure-web-app)
- [Use Key Vault references for App Service and Azure Functions](https://docs.microsoft.com/en-us/azure/app-service/app-service-key-vault-references)

## Module 08: Implement API Management
## Module 09: Develop App Service Logic Apps
## Module 10: Develop event-based solutions

### Links
- [Quickstart: Route custom events to web endpoint with the Azure portal and Event Grid](https://docs.microsoft.com/en-us/azure/event-grid/custom-event-quickstart-portal)
- [Tutorial: Respond to Azure Service Bus events received via Azure Event Grid by using Azure Logic Apps](https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-to-event-grid-integration-example)

## Module 11: Develop message-based solutions

### Links
- [Send messages to an Azure Service Bus topic and receive messages from subscriptions to the topic (.NET)](https://docs.microsoft.com/en-us/azure/service-bus-messaging/service-bus-dotnet-how-to-use-topics-subscriptions)
- [Get started with Azure Queue Storage using .NET](https://docs.microsoft.com/en-us/azure/storage/queues/storage-dotnet-how-to-use-queues?tabs=dotnet)
- [How to Send Email Using SendGrid with Azure](https://docs.microsoft.com/en-us/azure/sendgrid-dotnet-how-to-send-email) - SMTP service i Azure som service.

## Module 12: Instrument solutions to support monitoring and logging

### Links
- [Application Insights for ASP.NET Core applications](https://docs.microsoft.com/en-us/azure/azure-monitor/app/asp-net-core)
- [Using Search in Application Insights](https://docs.microsoft.com/en-us/azure/azure-monitor/app/diagnostic-search)

### Labs
- [Monitoring services that are deployed to Azure](https://github.com/MicrosoftLearning/AZ-204-DevelopingSolutionsforMicrosoftAzure/blob/master/Instructions/Labs/AZ-204_12_lab_ak.md)


## Module 13: Integrate caching and content delivery within solutions
### Links
- [Quickstart: Use Azure Cache for Redis with an ASP.NET web app](https://docs.microsoft.com/en-us/azure/azure-cache-for-redis/cache-web-app-howto)
- [Quickstart: Create an Azure CDN profile and endpoint](https://docs.microsoft.com/en-us/azure/cdn/cdn-create-new-endpoint)

### Labs

- [Enhancing a web application by using the Azure Content Delivery Network](https://github.com/MicrosoftLearning/AZ-204-DevelopingSolutionsforMicrosoftAzure/blob/master/Instructions/Labs/AZ-204_13_lab_ak.md)