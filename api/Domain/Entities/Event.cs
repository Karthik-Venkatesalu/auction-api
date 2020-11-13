using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Domain.Entities
{
    public class Event
    {
        public Event(string name, int id, DateTime start, DateTime end, int propertyID, int maxBidders)
        {
            Name = name;
            ID = id;
            StartTime = start;
            EndTime = end;
            PropertyID = propertyID;
            MaxBidders = maxBidders;
            //BiddingDataIDs = new List<int>();
        }

        /// <summary>
        /// Event Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Unique Event ID
        /// </summary>
        public int ID { get; private set; }

        /// <summary>
        /// Time when the auction event starts
        /// </summary>
        public DateTime StartTime { get; private set; }

        /// <summary>
        /// Time where auction event ends
        /// </summary>
        public DateTime EndTime { get; private set; }

        /// <summary>
        /// ID of the property which is under auction
        /// </summary>
        public int PropertyID { get; private set; }

        /// <summary>
        /// Maximun number of bidders 
        /// </summary>who can participate in the event.
        public int MaxBidders { get; private set; }
        /// <summary>
        /// ID of the bidders who are registered for the event. Typically ID will be the UserID of Bidder
        /// </summary>
        //public List<int> BiddingDataIDs { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public int? WinningBidAmount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? WinningBiddingDataID { get; set; }

        //[JsonIgnore]
        //public List<BiddingData> BiddingDataList { get; set; }

        /// <summary>
        /// Adds the passed in ID to the existing list.
        /// </summary>
        /// <param name="id"></param>
        //public void AddBiddingDataID(int id)
        //{
        //    BiddingDataIDs.Add(id);
        //}
    }
}
