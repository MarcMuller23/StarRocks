using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Entities
{
    public interface INewsMessage
    {
        int ID { get; set; }

        int AccountID { get; set; }
         string Title { get; set; }
         string Message { get; set; }
    }
}
