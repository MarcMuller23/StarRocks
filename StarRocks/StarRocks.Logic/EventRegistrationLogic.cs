using Org.BouncyCastle.Asn1.Mozilla;
using StarRocks.Interfaces.Entities;
using StarRocks.Interfaces.Handlers;
using StarRocks.Logic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Logic
{
    public class EventRegistrationLogic
    {
        private readonly IEventRegistrationDataBaseHandler _eventRegistrationDataBaseHandler;

        public EventRegistrationLogic(IEventRegistrationDataBaseHandler eventRegistrationDataBaseHandler)
        {
            _eventRegistrationDataBaseHandler = eventRegistrationDataBaseHandler;
        }

        private IEventRegistrationDataBaseHandler EventRegistrationDataBaseHandler { get; }

        public void CreateEventRegistration(IEventRegistration eventRegistration)
        {
            var _eventRegistration = new EventRegistration()
            {
                AccountID = eventRegistration.AccountID
            };
            EventRegistrationDataBaseHandler.CreateEventRegistration(_eventRegistration);
        }

        public List<IEventRegistration> GetAllEventRegistrations()
        {
            return EventRegistrationDataBaseHandler.GetAllEventRegistrations();
        }

        public IEventRegistration UpdateEventRegistration(IEventRegistration eventRegistration)
        {
            EventRegistrationDataBaseHandler.UpdateEventRegistration(eventRegistration);
            return eventRegistration;
        }

        public void DeleteEventRegistration(int eventRegistrationId)
        {
            EventRegistrationDataBaseHandler.DeleteEventRegistration(eventRegistrationId);
        }

        public IEventRegistration GetById(IEventRegistration eventRegistration)
        {
            return EventRegistrationDataBaseHandler.GetById(eventRegistration);
        }
    }   
}
