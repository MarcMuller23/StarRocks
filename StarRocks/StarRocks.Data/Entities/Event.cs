using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Data.Entities
{
    class Event
    {
        public int ID { get; set; }
        public int AccountID { get; set; }
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public int Description { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int MaxCapacity { get; set; }
    }
}
