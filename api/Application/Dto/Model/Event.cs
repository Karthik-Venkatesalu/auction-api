using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Application.Dto.Model
{
    public class Event
    {
        /// <summary>
        /// Event Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Unique Event ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Time when the auction event starts
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Time where auction event ends
        /// </summary>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// ID of the property which is under auction
        /// </summary>
        public int PropertyID { get; set; }

        /// <summary>
        /// Maximun number of bidders 
        /// </summary>who can participate in the event.
        public int MaxBidders { get; set; }
    }
}
