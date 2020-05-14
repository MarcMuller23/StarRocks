using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Asn1.Mozilla;
using StarRocks.Interfaces.Logic_Classes;
using StarRocks.Models;

namespace StarRocks.Controllers
{
    public class ReminderController : Controller
    {
        private readonly IReminderLogic _reminderLogic;
        public ReminderController(IReminderLogic reminderLogic)
        {
            _reminderLogic = reminderLogic;
        }

        //Read in CURD
        public ActionResult Index()
        {
            var allReminders = _reminderLogic.GetAllReminders();
            var reminders = new List<ReminderViewModel>();

            foreach (var reminder in allReminders)
            {
                reminders.Add(new ReminderViewModel
                {
                    ID = reminder.ID,
                    EventID = reminder.EventID,
                    Date = reminder.Date,
                    Message = reminder.Message
                });
            }
            return View(reminders);
        }

        //Delete in CRUD
        public ActionResult Delete(int ID)
        {
            _reminderLogic.DeleteReminder(ID);
            return RedirectToAction("Index");
        }

        //Create in CRUD
        [HttpGet]
        public ActionResult Create()
        {
            var reminderViewModel = new ReminderViewModel();
            return View(reminderViewModel);
        }

        [HttpPost]
        public ActionResult Create(ReminderViewModel reminderViewModel)
        {
            _reminderLogic.CreateReminder(reminderViewModel);
            return RedirectToAction("Index");
        }

        //Edit in CRUD
        [HttpGet]
        public ActionResult Edit()
        {
            var reminder = new ReminderViewModel();
            _reminderLogic.GetById(reminder);
            return View(reminder);
        }
        [HttpPost]
        public ActionResult Edit(ReminderViewModel reminder)
        {
            _reminderLogic.UpdateReminder(reminder);
            return RedirectToAction("Index");
        }
        public ActionResult AllReminders()
        {
            return View();
        }
    }
}