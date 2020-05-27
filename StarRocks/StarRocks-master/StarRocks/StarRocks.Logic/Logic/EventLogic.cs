using StarRocks.Data.Entities;
using StarRocks.Interfaces;
using StarRocks.Interfaces.Handlers;
using StarRocks.Interfaces.Logic_Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Logic
{
    public class EventLogic : IEventLogic
    {
        private readonly IEventDataBaseHandler eventDataBaseHandler;
        public EventLogic(IEventDataBaseHandler _eventDataBaseHandler)
        {
            eventDataBaseHandler = _eventDataBaseHandler;
        }
        public void CreateEvent(IEvent _event)
        {
            throw new NotImplementedException();
        }

        public void DeleteEvent(int eventeId)
        {
            eventDataBaseHandler.DeleteEvent(eventeId);
        }

        public IEnumerable<IEvent> GetAllEvents()
        {
            return eventDataBaseHandler.GetAllEvents();
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
