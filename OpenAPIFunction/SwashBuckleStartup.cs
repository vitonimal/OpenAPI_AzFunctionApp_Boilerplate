using System.Reflection;
using AzureFunctions.Extensions.Swashbuckle;
using OpenAPIFunction;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using System;
using Microsoft.OpenApi;
using AzureFunctions.Extensions.Swashbuckle.Settings;

[assembly: FunctionsStartup(typeof(SwashBuckleStartup))]
namespace OpenAPIFunction
{
    public class SwashBuckleStartup : FunctionsStartup
    {

        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.AddSwashBuckle(Assembly.GetExecutingAssembly(), opts => {
                opts.Documents = new[]
                {
                    new SwaggerDocument
                    {
                        Name = "v1",
                        Title = "NAME_OF_API",
                        Description = "Swagger test document",
                        Version = "v2"
                    }
                };
            });
        }
    }
}
