using Application.Property.Interfaces;
using Application.Event.Interfaces;
using Application.Dto.Request;
using Application.Dto.Model;
using Application.Response;
using Application.Dto.Response.Model;
using Application.BiddingRecord.Interfaces;
using Infrastructure.Interfaces;
using Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Service.Model;

namespace Infrastructure
{
    public class Facade : IFacade
    {
        private readonly Application.Property.Interfaces.IRepository _propertyRepository;
        private readonly Application.Event.Interfaces.IRepository _eventRepository;
        private readonly Application.BiddingRecord.Interfaces.IRepository _biddingRecordRepository;

        private readonly IPropertyRequestHandler _propertyRequestHandler;
        private readonly IBiddingRecordRequestHandler _biddingRecordRequestHandler;
        private readonly IEventRequestHandler _eventRequestHandler;

        public Facade(
            Application.Property.Interfaces.IRepository propertyRepository,
            Application.Event.Interfaces.IRepository eventRepository,
            Application.BiddingRecord.Interfaces.IRepository biddingRecordRepository,
            IPropertyRequestHandler propertyRequestHandler,
            IBiddingRecordRequestHandler biddingRecordRequestHandler,
            IEventRequestHandler eventRequestHandler)
        {
            _propertyRepository = propertyRepository;
            _propertyRequestHandler = propertyRequestHandler;

            _biddingRecordRepository = biddingRecordRepository;
            _biddingRecordRequestHandler = biddingRecordRequestHandler;

            _eventRepository = eventRepository;
            _eventRequestHandler = eventRequestHandler;
        }

        public Response<IEnumerable<Property>> GetPropertyCatalog()
        {
            return _propertyRequestHandler.GetPropertyCatalog();
        }

        public Response<Property> AddProperty(Request<Property> propertyRequest)
        {
            return _propertyRequestHandler.AddProperty(propertyRequest);
        }

        public Response<Event> AddEvent(Request<Event> eventRequest)
        {
            return _eventRequestHandler.CreateEvent(eventRequest);
        }

        public Response<IEnumerable<Event>> GetEvents()
        {
            return _eventRequestHandler.GetEvents();
        }

        public Response<Event> GetEvent(int eventID)
        {
            return _eventRequestHandler.GetEvent(eventID);
        }

        public BaseResponse AddBiddingRecord(Request<BiddingRecord> biddingRecordRequest)
        {
            return _biddingRecordRequestHandler.CreateRecord(biddingRecordRequest);
        }

        public Response<IEnumerable<BiddingRecord>> GetBiddingDataList(int? eventID)
        {
            return _biddingRecordRequestHandler.GetBiddingDataList(eventID);
        }

        public Response<WinningBidData> PerformAuction(int eventID)
        {
            return _eventRequestHandler.PerformAuction(eventID);
        }
    }
}
