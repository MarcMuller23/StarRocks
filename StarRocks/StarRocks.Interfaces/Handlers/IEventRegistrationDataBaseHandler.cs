using StarRocks.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Handlers
{
    public interface IEventRegistrationDataBaseHandler
    {
        List<IEventRegistration> GetAllEventRegistrations();

        void CreateEventRegistration(IEventRegistration E1);

        void UpdateEventRegistration(EventRegistration E1);

        void DeleteEventRegistration(int ID);
    }
}
