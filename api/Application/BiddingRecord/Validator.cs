using Application.BiddingRecord.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.BiddingRecord
{
    internal class Validator
    {
        private readonly Event.Interfaces.IRepository _eventRepository;
        private readonly IRepository _repository;

        public Validator(IRepository repository, Event.Interfaces.IRepository eventRepository)
        {
            _eventRepository = eventRepository ?? throw new ArgumentNullException("eventRepository");
            _repository = repository ?? throw new ArgumentNullException("repository");
        }

        public ValidationResult Validate(Dto.Model.BiddingRecord biddingRecord)
        {
            var @event = _eventRepository.GetEvent(biddingRecord.EventID);
            var bidderCount = _repository.GetBiddersCount(biddingRecord.EventID);

            return @event != null && @event.MaxBidders > bidderCount
                ? new ValidationResult() { Success = true }
                : new ValidationResult()
                {
                    Errors = new Dto.Response.Model.Errors()
                    {
                        ErrorList = new List<Dto.Response.Model.Error>
                        {
                            new Dto.Response.Model.Error()
                            {
                                Id = Guid.NewGuid().ToString(),
                                Detail = "Validation failed",
                                Status = HttpStatusCodes.BadRequestError.ToString(),
                                Title = "Invalid Request"
                            }
                        }
                    }
                };
        }
    }
}
