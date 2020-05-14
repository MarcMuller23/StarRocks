using StarRocks.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarRocks.Models
{
    public class ReminderViewModel : IReminder
    {
        public int ID { get ; set; }
        public int EventID { get; set; }
        public DateTime Date { get; set; }
        public string Message { get; set; }
    }
}
