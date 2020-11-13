using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Event
{
    public static class Mapper
    {
        public static Domain.Entities.Event MapToDomain(this Dto.Model.Event @event)
        {
            return new Domain.Entities.Event(
                @event.Name,
                @event.ID,
                @event.StartTime,
                @event.EndTime,
                @event.PropertyID,
                @event.MaxBidders);
        }

        public static Dto.Model.Event MapToDto(this Domain.Entities.Event @event)
        {
            return new Dto.Model.Event()
            {
                Name = @event.Name,
                ID = @event.ID,
                EndTime = @event.EndTime,
                MaxBidders = @event.MaxBidders,
                PropertyID = @event.PropertyID,
                StartTime = @event.StartTime
            };
        }
    }
}
