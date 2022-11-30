using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Business.Utilities.Middlewares;

public static class MiddlewareConfigurer
{
    public static IServiceCollection AddSessionMiddleware(this IServiceCollection services) => services.AddScoped<SessionMiddleware>();

    public static void UseSessionMiddleware(this IApplicationBuilder app) => app.UseMiddleware<SessionMiddleware>();

}
