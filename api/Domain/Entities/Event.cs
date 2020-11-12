using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Event
    {
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
        /// ID of the bidders who are registered for the event. Typically ID will be the UserID of Bidder
        /// </summary>
        public List<int> BidderIDs { get; private set; }

    }
}
