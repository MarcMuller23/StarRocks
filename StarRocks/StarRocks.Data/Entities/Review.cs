using StarRocks.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace StarRocks.Data.Entities
{
    public class Review:IReview
    {
        public int ID { get; set; }
        public int EventID { get; set; }
        public int AccountID { get; set; }
        public int Rating { get; set; }
        public string Message { get; set; }
    }
}
