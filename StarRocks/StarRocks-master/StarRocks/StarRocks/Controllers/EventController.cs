using System;
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
                    ID = _event.ID,
                    AccountID = _event.AccountID,
                    CategoryID = _event.CategoryID,
                    Date = _event.Date,
                    Description = _event.Description,
                    Location = _event.Location,
                    MaxCapacity = _event.MaxCapacity,
                    Name = _event.Name
                });
            }
            return View(_events);
        }

        public ActionResult Test()
        {
            var allEvents = _eventLogic.GetAllEvents();
            var _events = new List<EventViewModel>();

            foreach (var _event in allEvents)
            {
                _events.Add(new EventViewModel
                {
                    ID = _event.ID,
                    AccountID = _event.AccountID,
                    CategoryID = _event.CategoryID,
                    Date = _event.Date,
                    Description = _event.Description,
                    Location = _event.Location,
                    MaxCapacity = _event.MaxCapacity,
                    Name = _event.Name
                });
            }
            return View(_events);
        }

        //Delete in CRUD
        public ActionResult Delete(int ID)
        {
            _eventLogic.DeleteEvent(ID);
            return RedirectToAction("test");
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

        public ActionResult Participate(EventViewModel _event)
        {

            return View();
        }

        public ViewResult Details(int ID)
        {
            var eventviewmodel = new EventViewModel()
            {
                ID = ID,
            };
            var eventdetails = _eventLogic.GetById(eventviewmodel);
            var viewmodel = new EventViewModel()
            {
                ID = eventdetails.ID,
                CategoryID = eventdetails.CategoryID,
                AccountID = eventdetails.AccountID,
                Date = eventdetails.Date,
                Description = eventdetails.Description,
                Name = eventdetails.Name,
                Location = eventdetails.Location,
                MaxCapacity = eventdetails.MaxCapacity
            };

            return View(viewmodel);
        }
    }
}