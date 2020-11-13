using Application.Dto.Request;
using Application.Dto.Response.Model;
using Application.Service.Model;
using System.Collections.Generic;

namespace Application.Event.Interfaces
{
    public interface IEventRequestHandler
    {
        BaseResponse CreateEvent(Request<Dto.Model.Event> @event);
        Response<WinningBidData> PerformAuction(int eventID);
        Response<IEnumerable<Dto.Model.Event>> GetEvents();
        Response<Dto.Model.Event> GetEvent(int eventID);
    }
}