using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Data.Entities
{
    public class NewsMessage
    {
        public int ID { get; set; }
        public int AccountID { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
