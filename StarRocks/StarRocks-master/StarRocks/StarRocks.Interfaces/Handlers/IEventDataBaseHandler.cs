using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Handlers
{
    public interface IEventDataBaseHandler
    {
        IEnumerable<IEvent> GetAllEvents();

        void CreateEvent(IEvent E1);

        void UpdateEvent(IEvent E1);

        void DeleteEvent(int ID);

        IEvent GetById(IEvent _event);
    }
}
