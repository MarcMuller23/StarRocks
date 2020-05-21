using StarRocks.Interfaces.Entities;
using StarRocks.Interfaces.Handlers;
using StarRocks.Interfaces.Logic_Classes;
using StarRocks.Logic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Logic
{
    public class ReminderLogic : IReminderLogic
    {
        private readonly IReminderDataBaseHandler _reminderDataBaseHandler;
        public ReminderLogic(IReminderDataBaseHandler reminderDataBaseHandler)
        {
            _reminderDataBaseHandler = reminderDataBaseHandler;
        }
        private IReminderDataBaseHandler ReminderDatabaseHandler { get; }
        public void CreateReminder(IReminder reminder)
        {
            var _reminder = new Reminder()
            {
                ID = reminder.ID,
                EventID = reminder.EventID,
                Date = reminder.Date,
                Message = reminder.Message
            };
            ReminderDatabaseHandler.CreateReminder(_reminder);
        }

        public void DeleteReminder(int reminderId)
        {
            ReminderDatabaseHandler.DeleteReminder(reminderId);
        }

        public List<IReminder> GetAllReminders()
        {
            return ReminderDatabaseHandler.GetAllReminders();
        }

        public IReminder GetById(IReminder reminderId)
        {
            throw new NotImplementedException();
            //return ReminderDatabaseHandler.GetById(reminderId);
        }

        public IReminder UpdateReminder(IReminder reminder)
        {
            ReminderDatabaseHandler.UpdateReminder(reminder);
            return reminder;
        }
    }
}
