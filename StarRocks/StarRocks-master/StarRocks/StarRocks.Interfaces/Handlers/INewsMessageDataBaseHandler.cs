using StarRocks.Interfaces.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Interfaces.Handlers
{
    public interface INewsMessageDataBaseHandler
    {
        List<INewsMessage> GetAllNewsMessages();

        void CreateNewsMessage(INewsMessage R1);

        void UpdateNewsMessage(INewsMessage R1);

        void DeleteNewsMessage(int ID);
    }
}
