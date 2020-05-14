using StarRocks.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Logic_Classes
{
    public interface INewsMessageLogic
    {
        void CreateNewsMessage(INewsMessage newsMessage);
        List<INewsMessage> GetAllNewsMessages();
        INewsMessage UpdateNewsMessage(INewsMessage newsMessage);
        void DeleteNewsMessage(int newsMessageId);
        INewsMessage GetById(INewsMessage newsMessage);
    }
}
