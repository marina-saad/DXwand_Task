using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Azure;
using Azure.AI.TextAnalytics;

namespace DXwand
{
    public class Program
    {
        
         public static void Main(string[] args)
         {
             CreateHostBuilder(args).Build().Run();
         }
       /* static void LanguageDetectionExample(TextAnalyticsClient client)
        {
            DetectedLanguage detectedLanguage = client.DetectLanguage("Hello.");
            Console.WriteLine("Language:");
            Console.WriteLine($"\t{detectedLanguage.Name},\tISO-6391: {detectedLanguage.Iso6391Name}\n");
        }*/
     /*   static void Main(string[] args)
        {
            var client = new TextAnalyticsClient(endpoint, credentials);
            // You will implement these methods later in the quickstart.
            /*SentimentAnalysisExample(client);
            SentimentAnalysisWithOpinionMiningExample(client);*/
          /*  LanguageDetectionExample(client);
          /*  EntityRecognitionExample(client);
            EntityLinkingExample(client);
            RecognizePIIExample(client);
            KeyPhraseExtractionExample(client);*/

         /*   Console.Write("Press any key to exit.");
            Console.ReadKey();
        }*/
       
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
