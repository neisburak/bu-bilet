using System.Reflection;
using Core.Dependencies;
using Microsoft.Extensions.DependencyInjection;

namespace Core.Utilities;

public static class ServiceRegistrar
{
    public static IServiceCollection AddDependenciesFromAssembly(this IServiceCollection services, Assembly assembly)
    {
        return services.Scan(scan => scan.FromAssemblies(assembly)
       .AddClasses(classes => classes.AssignableTo<ITransientDependency>()).AsImplementedInterfaces().WithTransientLifetime()
       .AddClasses(classes => classes.AssignableTo<IScopedDependency>()).AsImplementedInterfaces().WithScopedLifetime()
       .AddClasses(classes => classes.AssignableTo<ISingletonDependency>()).AsImplementedInterfaces().WithSingletonLifetime());
    }
}
