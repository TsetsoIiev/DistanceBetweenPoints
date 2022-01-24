using DistanceBetweenPoints.Services.Interfaces;
using DistanceBetweenPoints.Services.Services;

namespace DistanceBetweenPoints.API.ServiceCollection
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection ConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IDistanceService, DistanceService>();

            return services;
        }
    }
}
