using Org.BouncyCastle.Asn1.Mozilla;
using StarRocks.Interfaces;
using StarRocks.Interfaces.Entities;
using StarRocks.Interfaces.Handlers;
using StarRocks.Interfaces.Logic_Classes;
using StarRocks.Logic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Logic
{
    public class EventRegistrationLogic : IEventRegistrationLogic
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
                EventID = eventRegistration.EventID,
                AccountID = eventRegistration.AccountID
            };
            
            _eventRegistrationDataBaseHandler.CreateEventRegistration(_eventRegistration);
            _eventRegistrationDataBaseHandler.UpdateCapacity(eventRegistration.EventID);
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
