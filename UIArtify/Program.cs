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
using UIArtify.Configurations;
using UIArtify.Services;
using UIArtify.ServicesExtension;
using UIArtify.Shared;
using UIArtify.Services;
using UIArtify.Helpers;

namespace UIArtify
{
    public class Program
    {
        public static async Task Main(String[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddScoped(x => {
                var apiUrl = new Uri(builder.Configuration["apiUrl"]);

                // use fake backend if "fakeBackend" is "true" in appsettings.json
                if (builder.Configuration["fakeBackend"] == "true")
                {
                    var fakeBackendHandler = new FakeBackendHandler(x.GetService<ILocalStorageService>());
                    return new HttpClient(fakeBackendHandler) { BaseAddress = apiUrl };
                }

                return new HttpClient() { BaseAddress = apiUrl };
            });
            builder.Services
                .AddScoped<IAccountService, AccountService>()
                .AddScoped<IAlertService, AlertService>()
                .AddScoped<Services.IHttpService, Services.HttpService>()
                .AddScoped<ILocalStorageService, LocalStorageService>()
                .AddScoped(
                    sp => new {BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)})
                .AddScoped<NavState>()
                .InitializeConfigurations(builder.Configuration);

            await builder.Build().RunAsync();
        }
    }
}