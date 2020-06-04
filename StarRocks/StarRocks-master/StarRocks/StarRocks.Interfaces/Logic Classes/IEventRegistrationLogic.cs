using StarRocks.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Logic_Classes
{
    public interface IEventRegistrationLogic
    {
        void CreateEventRegistration(IEventRegistration eventRegistration);
        List<IEventRegistration> GetAllEventRegistrations();
        IEventRegistration UpdateEventRegistration(IEventRegistration eventRegistration);
        void DeleteEventRegistration(int eventRegistrationId);
        IEventRegistration GetById(IEventRegistration eventRegistration);
        List<IAccount> GetAttendees(int eventId);
    }
}
