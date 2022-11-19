using Business.Utilities;
using Core.Options;

namespace App.Utilities;

public static class ServiceRegistrar
{
    public static void RegisterServices(this WebApplicationBuilder builder)
    {
        var mvc = builder.Services.AddControllersWithViews();

        if (builder.Environment.IsDevelopment())
        {
            mvc.AddRazorRuntimeCompilation();
        }

        builder.Services.AddHttpContextAccessor();

        builder.Services.AddDistributedMemoryCache();

        var apiConfiguration = builder.Configuration.GetApiConfiguration();

        builder.Services.AddSession(options =>
        {
            options.IdleTimeout = TimeSpan.FromMinutes(apiConfiguration.SessionTimeout);
        });

        builder.Services.AddBusinessServices(apiConfiguration);
    }

    private static ApiConfigurationOptions GetApiConfiguration(this IConfiguration configuration)
    {
        var options = configuration.GetSection("ApiConfiguration").Get<ApiConfigurationOptions>();
        if (options is null) throw new ArgumentNullException(nameof(ApiConfigurationOptions));
        return options;
    }
}