using StarRocks.Interfaces.Entities;
using StarRocks.Interfaces.Handlers;
using StarRocks.Interfaces.Logic_Classes;
using StarRocks.Logic.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarRocks.Logic
{
    public class NewsMessageLogic : INewsMessageLogic
    {
        private readonly INewsMessageDataBaseHandler _newsMessageDataBaseHandler;

        public NewsMessageLogic(INewsMessageDataBaseHandler newsMessageDataBaseHandler)
        {
            _newsMessageDataBaseHandler = newsMessageDataBaseHandler;
        }

        private INewsMessageDataBaseHandler NewsMessageDataBaseHandler { get; }

        public void CreateNewsMessage(INewsMessage newsMessage)
        {
            var _newsMessage = new NewsMessage()
            {
                ID = newsMessage.ID,
                AccountID = newsMessage.AccountID,
                Title = newsMessage.Title,
                Message = newsMessage.Message
            };
            NewsMessageDataBaseHandler.CreateNewsMessage(_newsMessage);

        }

        public void DeleteNewsMessage(int newsMessageId)
        {
            NewsMessageDataBaseHandler.DeleteNewsMessage(newsMessageId);
        }

        public List<INewsMessage> GetAllNewsMessages()
        {
            return NewsMessageDataBaseHandler.GetAllNewsMessages();
        }

        public INewsMessage GetById(INewsMessage newsMessage)
        {
            throw new NotImplementedException();
        }

        public INewsMessage UpdateNewsMessage(INewsMessage newsMessage)
        {
            NewsMessageDataBaseHandler.UpdateNewsMessage(newsMessage);
            return newsMessage;
        }
    }
}
