using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Property
    {
        /// <summary>
        /// Name of the property
        /// </summary>
        public string Name { get; private set; }
        
        /// <summary>
        /// Unique ID of the property
        /// </summary>
        public int ID { get; private set; }

        /// <summary>
        /// OwnerID represents the User ID who wants to sell the property
        /// </summary>
        public int OwnerID { get; set; }

        /// <summary>
        /// Base Price set by the owner
        /// </summary>
        public int BasePrice { get; set; }
    }
}
