using Infrastructure.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddSingleton(typeof(IFacade), typeof(Facade));
        }
    }
}
