using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UIArtify.Configurations;

namespace UIArtify.ServicesExtension
{
    public static class ServicesExtension
    {
        public static void InitializeConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<Api>(configuration.GetSection("Api"));
        }
    }
}