using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using Microsoft.Azure.WebJobs.Host;
using System.Threading.Tasks;
using System.Web;

namespace WebApplication1
{
    public class Test
    {
        public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
        {
            log.Info($"C# HTTP trigger function processed a request. RequestUri={req.RequestUri}");

            // parse query parameter
            object name = HttpUtility.ParseQueryString(req.RequestUri.Query).Get("name");
            
            // Set name to query string or body data

            var httpResponseMessage =
                new HttpResponseMessage(HttpStatusCode.Accepted) {Content = new StringContent($"Hi {name}")};
            return httpResponseMessage;
        }
    }
}