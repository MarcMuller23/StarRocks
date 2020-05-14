﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarRocks.Interfaces.Logic_Classes;
using StarRocks.Models;

namespace StarRocks.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventLogic _eventLogic;

        public EventController(IEventLogic eventLogic)
        {
            _eventLogic = eventLogic;
        }


        //Read in CRUD
        public ActionResult Index()
        {
            var allEvents = _eventLogic.GetAllEvents();
            var _events = new List<EventViewModel>();

            foreach (var _event in allEvents)
            {
                _events.Add(new EventViewModel
                {
                    //dasdasdasdasdasd
                });
            }
            return View(_events);
        }

        //Delete in CRUD
        public ActionResult Delete(int ID)
        {
            _eventLogic.DeleteEvent(ID);
            return RedirectToAction("Index");
        }

        //Create in CRUD
        [HttpGet]
        public ActionResult Create()
        {
            var eventViewModel = new EventViewModel();
            return View(eventViewModel);
        }

        [HttpPost]
        public ActionResult Create(EventViewModel _event)
        {
            _eventLogic.CreateEvent(_event);

            return RedirectToAction("Index");
        }

        //Edit in CRUD
        [HttpGet]
        public ActionResult Edit()
        {
            var _event = new EventViewModel();
            _eventLogic.GetById(_event);
            return View(_event);
        }

        [HttpPost]
        public ActionResult Edit(EventViewModel _event)
        {
            _eventLogic.UpdateEvent(_event);
            return RedirectToAction("Index");
        }

        public ActionResult AllMovies()
        {
            return View();
        }
    }
}