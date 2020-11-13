using Application.BiddingRecord.Interfaces;
using Application.Response;
using Application.Dto.Response.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using Application.Dto.Request;

namespace Application.BiddingRecord
{
    public class RequestHandler : IBiddingRecordRequestHandler
    {
        private readonly IRepository _repository;
        private readonly Event.Interfaces.IRepository _eventRepository;
        private readonly Validator _validator;

        public RequestHandler(
            IRepository repository,
            Event.Interfaces.IRepository eventRepository)
        {
            _eventRepository = eventRepository ?? throw new ArgumentNullException("eventRepository");
            _repository = repository ?? throw new ArgumentNullException("repository");

            _validator = new Validator(_repository, _eventRepository);
        }

        public BaseResponse CreateRecord(Request<Dto.Model.BiddingRecord> biddingRecordRequest)
        {
            var validationResult = _validator.Validate(biddingRecordRequest.Data);

            if (!validationResult.Success)
            {
                return Builder.BuildErrorResponse(validationResult.Errors);
            }

            var createdBiddingRecord = _repository.CreateBiddingRecord(biddingRecordRequest.Data.MapToDomain());
            return Builder.BuildSuccessResponse(createdBiddingRecord);
        }

        public Response<IEnumerable<Dto.Model.BiddingRecord>> GetBiddingDataList(int? eventID)
        {
            var biddingDataList = _repository.GetBiddingDataList(eventID);
            return Builder.BuildSuccessResponse(biddingDataList.Select(b => b.MapToDto()));
        }
    }
}
