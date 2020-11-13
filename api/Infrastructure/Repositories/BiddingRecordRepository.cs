using Application.BiddingRecord.Interfaces;
using Domain.Entities;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Infrastructure.Repositories
{
    public class BiddingRecordRepository : IRepository
    {
        private List<Domain.Entities.BiddingRecord> _biddingRecordList = new List<BiddingRecord>();

        public BiddingRecordRepository()
        {
        }

        public BiddingRecord CreateBiddingRecord(BiddingRecord record)
        {
            // TODO: Logic to persist in the data store must go here.
            record.ID = new Random().Next();
            _biddingRecordList.Add(record);
            return record;
        }

        public int GetBiddersCount(int eventID)
        {
            return _biddingRecordList.Count(b => b.EventID == eventID);
        }

        public IEnumerable<BiddingRecord> GetBiddingDataList(int? eventID)
        {
            return eventID.HasValue
                ? _biddingRecordList.Where(b => b.EventID == eventID).ToList()
                : _biddingRecordList;
        }
    }
}
