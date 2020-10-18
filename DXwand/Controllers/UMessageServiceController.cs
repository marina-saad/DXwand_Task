using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using DXwand.Entities;
using DXwand.Repository;
//using Google.Cloud.Translation.V2;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Docs.Samples;
using NTextCat;

using Microsoft.Extensions.Localization;
using Azure.AI.TextAnalytics;
using Azure;

namespace DXwand.Controllers
{
    
    [Route("api/UMessage/[action]")]
    [ApiController]
    public class UMessageServiceController : ControllerBase
    {
        private readonly IUMessageRep rep;
        private static readonly AzureKeyCredential credentials = new AzureKeyCredential("0274b14ca25e4a0db90f04913ecdaac3");
        private static readonly Uri endpoint = new Uri("https://mdetect.cognitiveservices.azure.com/");
        

        public UMessageServiceController(IUMessageRep rep)
        {
            this.rep = rep;
        }

    
        [HttpGet]
        public ActionResult Getalldata()
        {
            var data = rep.GetAll();
            return Ok(data);

        }

        [HttpPost]
        public IActionResult AddUMessage(UMessage obj)
        {
            var data = rep.AddObj(obj);
            var client = new TextAnalyticsClient(endpoint, credentials);
            DetectedLanguage detectedLanguage = client.DetectLanguage(rep.GetById(obj.Id).MContent);
            obj.LanguageId= detectedLanguage.Name;
            rep.EditObj(obj);
            
            
            return LocalRedirect("~/api/RMessage/GetData/1");
        }


        }
}
