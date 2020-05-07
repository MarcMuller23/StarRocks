using StarRocks.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Handlers
{
    public interface IReminderDataBaseHandler
    {
        List<IReminder> GetAllReminders();

        void CreateReminder(IReminder R1);

        void UpdateReminder(IReminder R1);

        void DeleteReminder(int ID);
    }
}
