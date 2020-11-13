using Microsoft.Extensions.DependencyInjection;
using Application.BiddingRecord.Interfaces;
using Application.Event.Interfaces;
using Application.Property.Interfaces;
using Application.Service.Interfaces;
using Application.Service;

namespace Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplicationServices(this IServiceCollection services)
        {
            services.AddTransient(typeof(IBiddingRecordRequestHandler), typeof(BiddingRecord.RequestHandler));
            services.AddTransient(typeof(IEventRequestHandler), typeof(Event.RequestHandler));
            services.AddTransient(typeof(IPropertyRequestHandler), typeof(Property.RequestHandler));
            services.AddTransient(typeof(IService), typeof(AuctionService));
        }
    }
}
