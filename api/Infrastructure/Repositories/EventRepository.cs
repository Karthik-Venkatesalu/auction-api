using Application.Event.Interfaces;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Infrastructure.Repositories
{
    public class EventRepository : IRepository
    {
        private List<Event> _events = new List<Event>();

        public EventRepository()
        {
            _events = new List<Event>()
            {
                new Event("Event1", 1, DateTime.Now.AddDays(1), DateTime.Now.AddDays(1).AddMinutes(15), 1, 5),
                new Event("Event2", 2, DateTime.Now.AddDays(2), DateTime.Now.AddDays(2).AddMinutes(15), 1, 5),
                new Event("Event3", 3, DateTime.Now.AddDays(3), DateTime.Now.AddDays(3).AddMinutes(15), 1, 5)
            };
        }

        public IEnumerable<Event> GetEvents()
        {
            return _events;
        }

        public Event GetEvent(int eventID)
        {
            // using FirstOrDefault instead of SingleOrDefault to avoid iterating the complete list.
            // Integrity must be taken care by Data Store or by client application if data store is NoSQL
            return _events.FirstOrDefault(e => e.ID == eventID);
        }

        public Event CreateEvent(Event @event)
        {
            // TODO: Logic to persist in the data store must go here.
            var newEvent = new Event(@event.Name, new Random().Next(), @event.StartTime, @event.EndTime, @event.PropertyID, @event.MaxBidders);
            _events.Add(newEvent);
            return newEvent;
        }
    }
}
