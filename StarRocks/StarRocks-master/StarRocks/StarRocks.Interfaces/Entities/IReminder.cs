using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Entities
{
    public interface IReminder
    {
        int ID { get; set; }
        int EventID { get; set; }
         DateTime Date { get; set; }
         string Message { get; set; }
    }
}
