using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Runtime;

namespace TemplateFunctionApp
{
    public static class Function2
    {
        //static byte[] memory = new byte[0];
        static string memString = "hi";

        [FunctionName("Function2")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            //GCSettings.LatencyMode = .LowLatency;

            if (name == "collectgarbage")
            {
                GC.Collect();
            }

            if (name == "setlatency")
            {
                GCSettings.LatencyMode = GCLatencyMode.LowLatency;
            }

            if (name == "resetlatency")
            {
                GCSettings.LatencyMode = GCLatencyMode.Interactive;
            }

            if (name == "sustained")
            {
                GCSettings.LatencyMode = GCLatencyMode.SustainedLowLatency;
            }

            try
            {
                if (!(name.Contains("collectgarbage") || name.Contains("setlatency") || name.Contains("resetlatency") || name.Contains("sustained")))
                {
                    for (int x = 0; x < Convert.ToInt32(name); x++)
                    {
                        memString += "nameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlf" +
                            "nameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlf" +
                            "nameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlf" +
                            "nameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlf" +
                            "nameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlf" +
                            "nameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlf" +
                            "nameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlf" +
                            "nameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlf" +
                            "nameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlfnameksjdflksjdlkfjlskdjflksdjflksdlfkjsdlf";

                        //memory = new byte[1000 * 1000 * 10]; // Ten million bytes
                        //memory[0] = 1; // Set memory (prevent allocation from being optimized out)
                    }
                }
            }
            catch (Exception exc)
            {
                log.LogInformation(exc.Message);
                return new BadRequestObjectResult($"BAD REQUEST OBJECT\n\n" +
                    $"{exc.Message}\n\n" +
                    $"Collect Garbage = collectgarbage\n\n" +
                    $"Set to LowLatency = setlatency\n\n" +
                    $"Reset to Interactive = resetlatency");
            }

            log.LogInformation(Environment.GetEnvironmentVariable("WEBSITE_COUNTERS_ALL"));

            return new OkObjectResult(Environment.GetEnvironmentVariable("WEBSITE_COUNTERS_ALL"));
                
                //$"{GCSettings.IsServerGC.ToString()} | {GCSettings.LatencyMode.ToString()} | {GC.GetTotalMemory(false)} \n\n" +
                //$"Collect Garbage = collectgarbage\n\n" +
                //$"Set to LowLatency = setlatency\n\n" +
                //$"Reset to Interactive = resetlatency");
        }
    }
}
