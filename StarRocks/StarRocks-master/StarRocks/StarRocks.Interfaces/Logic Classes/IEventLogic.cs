using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Logic_Classes
{
    public interface IEventLogic
    {
        void CreateEvent(IEvent _event);
        IEnumerable<IEvent> GetAllEvents();
        ICategorie_Interest UpdateEvent(IEvent _event);
        void DeleteEvent(int eventeId);
        IEvent GetById(IEvent _event);
    }
}
