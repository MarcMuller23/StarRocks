using StarRocks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarRocks.Models
{
    public class EventViewModel : IEvent
    {
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int AccountID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int CategoryID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Location { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int MaxCapacity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
