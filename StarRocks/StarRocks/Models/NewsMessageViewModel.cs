using StarRocks.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarRocks.Models
{
    public class NewsMessageViewModel : INewsMessage
    {
        public int ID { get; set; }
        public int AccountID { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
    }
}
