using Infrastructure.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddSingleton(typeof(IFacade), typeof(Facade));
            services.AddSingleton(typeof(Application.BiddingRecord.Interfaces.IRepository), typeof(Repositories.BiddingRecordRepository));
            services.AddSingleton(typeof(Application.Event.Interfaces.IRepository), typeof(Repositories.EventRepository));
            services.AddSingleton(typeof(Application.Property.Interfaces.IRepository), typeof(Repositories.PropertyRepository));
        }
    }
}
