using System;
using System.Collections.Generic;
using System.Text;

namespace Application.BiddingRecord
{
    public static class Mapper
    {
        public static Domain.Entities.BiddingRecord MapToDomain(this Dto.Model.BiddingRecord @event)
        {
            return new Domain.Entities.BiddingRecord()
            {
                EventID = @event.EventID,
                ID = @event.ID,
                Incrementer = @event.Incrementer,
                MaximumBid = @event.MaximumBid,
                StartingBid = @event.StartingBid,
                UserID = @event.UserID
            };
        }

        public static Dto.Model.BiddingRecord MapToDto(this Domain.Entities.BiddingRecord @event)
        {
            return new Dto.Model.BiddingRecord()
            {
                EventID = @event.EventID,
                UserID = @event.UserID,
                StartingBid = @event.StartingBid,
                MaximumBid = @event.MaximumBid,
                Incrementer = @event.Incrementer,
                ID = @event.ID
            };
        }
    }
}
