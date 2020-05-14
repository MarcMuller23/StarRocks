using StarRocks.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Logic.Model
{
    public class Reminder : IReminder
    {
        public int ID { get; set; }
        public int EventID { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
    }
}
