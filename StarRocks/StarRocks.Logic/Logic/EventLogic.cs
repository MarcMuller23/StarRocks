using StarRocks.Interfaces;
using StarRocks.Interfaces.Logic_Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Logic
{
    public class EventLogic : IEventLogic
    {
        public void CreateEvent(IEvent _event)
        {
            throw new NotImplementedException();
        }

        public void DeleteEvent(int eventeId)
        {
            throw new NotImplementedException();
        }

        public List<IEvent> GetAllEvents()
        {
            throw new NotImplementedException();
        }

        public IEvent GetById(IEvent _event)
        {
            throw new NotImplementedException();
        }

        public ICategorie_Interest UpdateEvent(IEvent _event)
        {
            throw new NotImplementedException();
        }
    }
}
