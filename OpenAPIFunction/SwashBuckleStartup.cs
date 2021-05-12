using System.Reflection;
using AzureFunctions.Extensions.Swashbuckle;
using OpenAPIFunction;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;

[assembly: WebJobsStartup(typeof(SwashBuckleStartup))]
namespace OpenAPIFunction
{
    public class SwashBuckleStartup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.AddSwashBuckle(Assembly.GetExecutingAssembly());
        }
    }
}
