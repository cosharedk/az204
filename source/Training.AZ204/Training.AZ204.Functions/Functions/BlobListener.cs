using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Training.AZ204.Functions.Functions
{
    public static class BlobListener
    {
        [FunctionName("BlobListener")]
        public static void Run([BlobTrigger("filerne/{name}", Connection = "StorageConnectionString")]Stream myBlob, string name, ILogger log, 
            [Blob("processed-files/{name}", FileAccess.Write,Connection ="StorageConnectionstring")] Stream newFile)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
            newFile = myBlob;

        }
    }
}
