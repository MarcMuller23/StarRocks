using StarRocks.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarRocks.Models
{
    public class ReviewViewModel : IReview
    {
        public int ID { get; set; }
        public int EventID { get; set; }
        public int AccountID { get; set; }
        public int Rating { get; set; }
        public string Message { get; set; }
    }
}
