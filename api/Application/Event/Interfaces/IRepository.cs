using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Application.Event.Interfaces
{
    public interface IRepository
    {
        IEnumerable<Domain.Entities.Event> GetEvents();
        Domain.Entities.Event GetEvent(int eventID);
        Domain.Entities.Event CreateEvent(Domain.Entities.Event @event);
    }
}
