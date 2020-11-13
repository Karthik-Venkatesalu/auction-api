using Application.Dto.Request;
using Application.Dto.Response.Model;
using Application.Dto.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Application.Service.Model;

namespace Infrastructure.Interfaces
{
    public interface IFacade
    {
        // Property
        Response<IEnumerable<Property>> GetPropertyCatalog();
        Response<Property> AddProperty(Request<Property> propertyRequest);

        // Event
        Response<Event> AddEvent(Request<Event> eventRequest);
        Response<IEnumerable<Event>> GetEvents();
        Response<Event> GetEvent(int eventID);
        Response<WinningBidData> PerformAuction(int eventID);

        // Bidding Record
        BaseResponse AddBiddingRecord(Request<BiddingRecord> biddingRecordRequest);
        Response<IEnumerable<BiddingRecord>> GetBiddingDataList(int? eventID);
    }
}
