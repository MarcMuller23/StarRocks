﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarRocks.Interfaces.Logic_Classes;
using StarRocks.Models;

namespace StarRocks.Controllers
{
    public class EventRegistrationController : Controller
    {
        private readonly IEventRegistrationLogic _eventRegistrationLogic;

        public EventRegistrationController(IEventRegistrationLogic eventRegistration)
        {
            _eventRegistrationLogic = eventRegistration;
        }


        //Read in CRUD
        public ActionResult Index()
        {
            var allEventRegistrations = _eventRegistrationLogic.GetAllEventRegistrations();
            var eventRegistrations = new List<EventRegistrationViewModel>();

            foreach (var eventRegistration in allEventRegistrations)
            {
                eventRegistrations.Add(new EventRegistrationViewModel
                {
                    EventID = eventRegistration.EventID,
                    AccountID = eventRegistration.AccountID
                });
            }
            return View(eventRegistrations);
        }

        //Delete in CRUD
        public ActionResult Delete(int ID)
        {
            _eventRegistrationLogic.DeleteEventRegistration(ID);
            return RedirectToAction("Index");
        }

        //Create in CRUD
        [HttpGet]
        public ActionResult Create()
        {
            var eventRegistrationViewModel = new EventRegistrationViewModel();
            return View(eventRegistrationViewModel);
        }

        [HttpPost]
        public ActionResult Create(EventRegistrationViewModel eventRegistration)
        {
            _eventRegistrationLogic.CreateEventRegistration(eventRegistration);

            return RedirectToAction("Index");
        }

        //Edit in CRUD
        [HttpGet]
        public ActionResult Edit()
        {
            var eventRegistration = new EventRegistrationViewModel();
            _eventRegistrationLogic.GetById(eventRegistration);
            return View(eventRegistration);            
        }

        [HttpPost]
        public ActionResult Edit(EventRegistrationViewModel eventRegistration)
        {
            _eventRegistrationLogic.UpdateEventRegistration(eventRegistration);
            return RedirectToAction("Index");
        }

        public ActionResult AllMovies()
        {
            return View();
        }
    }
}