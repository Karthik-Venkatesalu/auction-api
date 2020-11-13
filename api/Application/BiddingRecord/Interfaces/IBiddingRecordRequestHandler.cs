using Application.Dto.Request;
using Application.Dto.Response.Model;
using System.Collections.Generic;

namespace Application.BiddingRecord.Interfaces
{
    public interface IBiddingRecordRequestHandler
    {
        /// <summary>
        /// CreateRecord method creates and adds a new bidding record in the data store and returns the newly created entity.
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        BaseResponse CreateRecord(Request<Dto.Model.BiddingRecord> record);
        Response<IEnumerable<Dto.Model.BiddingRecord>> GetBiddingDataList(int? eventID);
    }
}