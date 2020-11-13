using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Dto.Model
{
    public class BiddingRecord
    {
        /// <summary>
        /// 
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int StartingBid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Incrementer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int MaximumBid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int EventID { get; set; }
    }
}
