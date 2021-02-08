# Værktøjer
Jeg bruger en del værktøjer i min undervisning, der gør hverdagen lettere - her er installation-guides til de fleste af dem:

- [Visual Studio Community Edition](https://visualstudio.microsoft.com/)
- [Visual Studio Code](https://code.visualstudio.com/)
- [Installer AZ-PowerShell modulet til Azure](https://docs.microsoft.com/en-us/powershell/azure/install-az-ps?view=azps-5.4.0)
- Afinstaller det gamle PowerShell-modul (AzureRM)
- [Get started with Azure CLI](https://docs.microsoft.com/en-us/cli/azure/get-started-with-azure-cli) - hvad skal installeres og hvordan skriver jeg mine første scripts i CLI
- [Azure Storage Explorer](https://azure.microsoft.com/en-us/features/storage-explorer/) - er indbygget i portalen i vore dage, men kan hentes som desktop-progam.
- [Azure Functions Core Tools](https://docs.microsoft.com/en-us/azure/azure-functions/functions-run-local#install-the-azure-functions-core-tools) - core tools til Azure Functions, hvis man skal lave dem i Visual Studio Code

# Certificerings-links
Til de der skal certificeres, bruger jeg følgende links:
- [MeasureUp](https://www.measureup.com) - generator med eksamens-spørgsmål
- [Pluralsight](https://www.pluralsight.com) - videotjeneste med tons-vis af instruktions-videoer om blandt meget andet Azure

# Module 01: Creating Azure App Service Web Apps

## Links
- [Docker Build: A Beginner’s Guide to Building Docker Images](https://stackify.com/docker-build-a-beginners-guide-to-building-docker-images/)
- [Set up staging environments in Azure App Service](https://docs.microsoft.com/en-us/azure/app-service/deploy-staging-slots)

# Module 02: Implement Azure Functions

## Links

- [Create your first function in Azure using Visual Studio](https://docs.microsoft.com/en-us/azure/azure-functions/functions-create-your-first-function-visual-studio) - basal begynder guide til at lave en Azure Function i Visual Studio med C#
- [Develop Azure Functions by using Visual Studio Code](https://docs.microsoft.com/en-us/azure/azure-functions/functions-develop-vs-code?tabs=csharp) - guide 
- [Azure Functions – Time Trigger (CRON) Cheat Sheet](https://arminreiter.com/2017/02/azure-functions-time-trigger-cron-cheat-sheet/) - lidt hjælp til at lave CRON expressions til Timer-baserede functions
- [Azure Functions time zone issue](https://www.serverlessnotes.com/docs/azure-functions-time-zone-issue) - få Azure Functions til at eksekvere i den tidszone, du gerne vil have den til.

## Kodeeksempler
I function-app-projektet i demo-koden findes en del eksempler på Azure-functions i praksis:

- [VMStartUp](../source/Training.AZ204/Training.AZ204.Functions/fimctopms/../Functions/VMStartUp.cs) - starter de virtuelle maskiner i en bestemt resource-gruppe
- VMShutDown - starter og stopper de virtuelle maskiner i en bestemt resource-gruppe
- BlobTrigger - eksekverer, når der lander en blob i en storage account
- QueueTrigger - eksekverer, når der lander en besked på køen
  
# Module 03: Develop solutions that use blob storage
# Module 04: Develop solutions that use Cosmos DB storage
# Module 05: Implement IaaS solutions
# Module 06: Implement user authentication and authorization

## Kodeeksempler
- Der er et eksempel på oAuth via en app-registrering i [VMStartUp-function-appen](../source/Training.AZ204/Training.AZ204.Functions/Functions/VMStartUp.cs)

# Module 07: Implement secure cloud solutions
# Module 08: Implement API Management
# Module 09: Develop App Service Logic Apps
# Module 10: Develop event-based solutions
# Module 11: Develop message-based solutions
# Module 12: Instrument solutions to support monitoring and logging
# Module 13: Integrate caching and content delivery within solutions
## Links
[Quickstart: Use Azure Cache for Redis with an ASP.NET web app](https://docs.microsoft.com/en-us/azure/azure-cache-for-redis/cache-web-app-howto)
