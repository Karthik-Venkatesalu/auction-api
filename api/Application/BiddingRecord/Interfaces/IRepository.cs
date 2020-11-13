using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Application.BiddingRecord.Interfaces
{
    public interface IRepository
    {
        IEnumerable<Domain.Entities.BiddingRecord> GetBiddingDataList(int? eventID);

        int GetBiddersCount(int eventID);

        Domain.Entities.BiddingRecord CreateBiddingRecord(Domain.Entities.BiddingRecord record);
    }
}
