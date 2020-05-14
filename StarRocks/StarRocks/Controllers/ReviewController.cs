using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarRocks.Interfaces.Logic_Classes;
using StarRocks.Models;

namespace StarRocks.Controllers
{
    public class ReviewController : Controller
    {
        private readonly IReviewLogic _reviewLogic;
        public ReviewController(IReviewLogic reviewLogic)
        {
            _reviewLogic = reviewLogic;
        }
        //Read in CRUD
        public ActionResult Index()
        {
            var allReviews = _reviewLogic.GetAllReviews();
            var reviews = new List<ReviewViewModel>();

            foreach (var review in allReviews)
            {
                reviews.Add(new ReviewViewModel
                {
                    ID = review.ID,
                    EventID = review.EventID,
                    AccountID = review.AccountID,
                    Rating = review.Rating,
                    Message = review.Message
                });
            }
            return View(reviews);
        }

        //Delete in CRUD
        public ActionResult Delete(int ID)
        {
            _reviewLogic.DeleteReview(ID);
            return RedirectToAction("Index");
        }

        //Create in CRUD
        [HttpGet]
        public ActionResult Create()
        {
            var review = new ReviewViewModel();
            return View(review);
        }

        [HttpPost]
        public ActionResult Create(ReviewViewModel reviewViewModel) 
        {
            _reviewLogic.CreateReview(reviewViewModel);
            return RedirectToAction("Index");
        }

        //Edit in CRUD
        [HttpGet]
        public ActionResult Edit()
        {
            var reviewViewModel = new ReviewViewModel();
            _reviewLogic.GetById(reviewViewModel);
            return View(reviewViewModel);
        }

        [HttpPost]
        public ActionResult Edit(ReviewViewModel reviewViewModel)
        {
            _reviewLogic.UpdateReview(reviewViewModel);
            return RedirectToAction("Index");
        }

        public ActionResult AllReviews()
        {
            return View();
        }
    }
}