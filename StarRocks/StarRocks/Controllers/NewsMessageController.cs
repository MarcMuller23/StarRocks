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
    public class NewsMessageController : Controller
    {
        private readonly INewsMessageLogic _newsMessageLogic;

        public NewsMessageController(INewsMessageLogic newsMessageLogic)
        {
            _newsMessageLogic = newsMessageLogic;
        }

        //Read in CRUD
        public ActionResult Index()
        {

            var allNewsMessages = _newsMessageLogic.GetAllNewsMessages();
            var newsMessages = new List<NewsMessageViewModel>();

            foreach (var newsMessage in allNewsMessages)
            {
                newsMessages.Add(new NewsMessageViewModel
                {
                    ID = newsMessage.ID,
                    AccountID = newsMessage.AccountID,
                    Title = newsMessage.Title,
                    Message = newsMessage.Message
                });
            }
            return View(allNewsMessages);
        }

        public ActionResult Delete(int ID)
        {
            _newsMessageLogic.DeleteNewsMessage(ID);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            var newsMessageModel = new NewsMessageViewModel();
            return View(newsMessageModel);
        }

        [HttpPost]
        public ActionResult Create(NewsMessageViewModel newsMessageViewModel)
        {
            _newsMessageLogic.CreateNewsMessage(newsMessageViewModel);
            return RedirectToAction("Index");
        }

        //Edit in CRUD
        [HttpGet]
        public ActionResult Edit()
        {
            var newsMessageViewModel = new NewsMessageViewModel();
            _newsMessageLogic.GetById(newsMessageViewModel);
            return View(newsMessageViewModel);
        }

        [HttpPost]
        public ActionResult Edit(NewsMessageViewModel newsMessageViewModel)
        {
            _newsMessageLogic.UpdateNewsMessage(newsMessageViewModel);
            return RedirectToAction("Index");
        }

        public ActionResult AllNewsMessages()
        {
            return View();
        }

    }
}