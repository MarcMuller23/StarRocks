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
            eventDataBaseHandler.CreateEvent(_event);
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
            return eventDataBaseHandler.GetById(_event);
        }

        public IEvent UpdateEvent(IEvent _event)
        {
            eventDataBaseHandler.UpdateEvent(_event);
            return _event;
        }

    }
}
