using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Application.BiddingRecord.Interfaces;
using Application.Service.Interfaces;
using Application.Service.Model;

namespace Application.Service
{
    public class AuctionService : IService
    {
        private readonly IRepository _biddingRecordRepository;

        public AuctionService(IRepository biddingRecordRepository)
        {
            _biddingRecordRepository = biddingRecordRepository;
        }

        public WinningBidData Execute(int eventID)
        {
            var biddingRecords = _biddingRecordRepository
                .GetBiddingDataList(eventID)
                .ToList();

            while (biddingRecords.Count > 1)
            {
                var losers = biddingRecords.OrderByDescending(b => b.StartingBid).Skip(1);

                foreach (var loser in losers)
                {
                    loser.StartingBid += loser.Incrementer;

                    if (loser.StartingBid > loser.MaximumBid)
                    {
                        biddingRecords.Remove(loser);
                    }
                }
            }

            var winningBidRecord = biddingRecords.FirstOrDefault();
            return
                winningBidRecord != null
                ? new WinningBidData()
                {
                    WinningBid = winningBidRecord.StartingBid,
                    WinningBiddingDataID = winningBidRecord.ID
                }
                : null;
        }
    }
}
