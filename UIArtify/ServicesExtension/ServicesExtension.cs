using BlazorDownloadFile;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UIArtify.Configurations;
using UIArtify.Interfaces;
using UIArtify.Services;

namespace UIArtify.ServicesExtension
{
    public static class ServicesExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IQueryService, QueryService>();
            services.AddBlazorDownloadFile();
            return services;
        }
        public static void InitializeConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<Api>(configuration.GetSection("Api"));
        }
    }
}