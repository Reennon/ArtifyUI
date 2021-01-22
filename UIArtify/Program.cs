using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Text;
using HttpClientService.Blazor;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using RazorComponentsPreview;
using UIArtify.Services;
using UIArtify.Shared;

namespace UIArtify
{
    public class Program
    {
        public static async Task Main(String[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services
                .AddScoped(
                    sp => new {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)})
                .AddScoped<NavState>();

            await builder.Build().RunAsync();
        }
    }
}