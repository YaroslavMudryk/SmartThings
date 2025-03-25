using Microsoft.Extensions.DependencyInjection;

namespace SmartThings;

public static class ServiceCollectionsExtensions
{
    public static IServiceCollection AddSmartThingsClient(this IServiceCollection services, string token)
    {
        services.AddScoped<ISmartThingsClient>((sp) => new SmartThingsClient(token));

        return services;
    }
}
