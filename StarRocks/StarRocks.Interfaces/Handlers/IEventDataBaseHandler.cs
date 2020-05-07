using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Handlers
{
    public interface IEventDataBaseHandler
    {
        List<IEvent> GetAllEvents();

        void CreateEvent(IEvent E1);

        void UpdateEvent(IEvent E1);

        void DeleteEvent(int ID);
    }
}
