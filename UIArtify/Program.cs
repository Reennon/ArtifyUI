using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using UIArtify.Services;
using UIArtify.ServicesExtension;

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
                .AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) })
                .AddServices()
                .InitializeConfigurations(builder.Configuration);

            await builder.Build().RunAsync();
        }
    }
}