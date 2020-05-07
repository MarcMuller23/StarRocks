using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Entities
{
    public interface IReview
    {
        int ID { get; set; }

        int EventID { get; set; }
         int AccountID { get; set; }
         int Rating { get; set; }
         string Message { get; set; }
    }
}
