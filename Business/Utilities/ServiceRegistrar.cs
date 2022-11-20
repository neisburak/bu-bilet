using System.Reflection;
using Business.ApiClient;
using Core.Options;
using Core.Utilities;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Utilities;

public static class ServiceRegistrar
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services, ApiConfigurationOptions options)
    {
        return services.AddHttpClient(options).AddDependenciesFromAssembly(Assembly.GetExecutingAssembly());
    }

    public static IServiceCollection AddHttpClient(this IServiceCollection services, ApiConfigurationOptions options)
    {
        services.AddHttpClient(ApiClientConstants.Name, client =>
        {
            client.BaseAddress = new Uri(options.BaseUrl);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.AddBasicAuthenticationHeader(options.Token);
        });

        options.SetUrls();
        
        return services;
    }
}
