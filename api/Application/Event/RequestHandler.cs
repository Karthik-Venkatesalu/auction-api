using Application.Event.Interfaces;
using Application.Response;
using Application.Dto.Response.Model;
using Application.Service.Interfaces;
using Application.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Application.Dto.Request;

namespace Application.Event
{
    public class RequestHandler : IEventRequestHandler
    {
        private readonly IRepository _repository;
        private readonly BiddingRecord.Interfaces.IRepository _biddingRecordRepository;
        private readonly Property.Interfaces.IRepository _propertyRepository;

        public RequestHandler(
            IRepository repository, 
            BiddingRecord.Interfaces.IRepository biddingRecordRepository,
            Property.Interfaces.IRepository propertyRepository)
        {
            _repository = repository ?? throw new ArgumentNullException("repository");
            _biddingRecordRepository = biddingRecordRepository ?? throw new ArgumentNullException("biddingRecordRepository");
            _propertyRepository = propertyRepository ?? throw new ArgumentNullException("propertyRepository");
        }

        public BaseResponse CreateEvent(Request<Dto.Model.Event> eventRequest)
        {
            var validationResult = new Validator(_propertyRepository).Validate(eventRequest.Data);

            if (!validationResult.Success)
            {
                return Builder.BuildErrorResponse(validationResult.Errors);
            }

            return Builder.BuildSuccessResponse(_repository.CreateEvent(eventRequest.Data.MapToDomain()).MapToDto());
        }

        public Response<Dto.Model.Event> GetEvent(int eventID)
        {
            return Builder.BuildSuccessResponse(_repository.GetEvent(eventID).MapToDto());
        }

        public Response<IEnumerable<Dto.Model.Event>> GetEvents()
        {
            return Builder.BuildSuccessResponse(_repository.GetEvents().Select(e => e.MapToDto()));
        }

        public Response<WinningBidData> PerformAuction(int eventID)
        {
            // Temporary code. PerforAuction will be done by the Scheduler.
            return Builder.BuildSuccessResponse(new Service.AuctionService(_biddingRecordRepository).Execute(eventID));
        }
    }
}
