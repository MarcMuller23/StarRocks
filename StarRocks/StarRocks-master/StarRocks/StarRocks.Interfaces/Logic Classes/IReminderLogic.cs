using StarRocks.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Logic_Classes
{
    public interface IReminderLogic
    {
        void CreateReminder(IReminder reminder);
        List<IReminder> GetAllReminders();
        IReminder UpdateReminder(IReminder reminder);
        void DeleteReminder(int reminderId);
        IReminder GetById(IReminder reminderId);
    }
}
