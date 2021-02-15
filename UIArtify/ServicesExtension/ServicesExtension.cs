using System;
using System.Linq;
using BlazorDownloadFile;
using HttpClientService.Blazor;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Primitives;
using UIArtify.Configurations;
using UIArtify.Interfaces;
using UIArtify.Services;

namespace UIArtify.ServicesExtension
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<NavState>();
            services.AddScoped<IQueryService, QueryService>();
            services.AddScoped<IApiService, ApiService>();
            services.AddBlazorDownloadFile();

            return services;
        }
        public static void InitializeConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<Api>(configuration.GetSection("Api"));
        }
    }
}