using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class User
    {
        public string Name { get; private set; }
        public int ID { get; private set; }
        public string EmailID { get; private set; }
    }
}
