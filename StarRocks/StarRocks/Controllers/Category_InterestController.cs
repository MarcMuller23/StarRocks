using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarRocks.Interfaces.Logic_Classes;
using StarRocks.Models;

namespace StarRocks.Controllers
{
    public class Category_InterestController : Controller
    {
        private readonly ICategory_InterestLogic _category_InterestLogic;

        public Category_InterestController(ICategory_InterestLogic category_InterestLogic)
        {
            _category_InterestLogic = category_InterestLogic;
        }


        //Read in CRUD
        public ActionResult Index()
        {
            var allCategorie_Interests = _category_InterestLogic.GetAllCategoryInterests();
            var category_interests = new List<Category_InterestViewModel>();

            foreach (var _category_interest in allCategorie_Interests)
            {
                category_interests.Add(new Category_InterestViewModel
                {
                    //dasdasdasdasdasd
                });
            }
            return View(category_interests);
        }

        //Delete in CRUD
        public ActionResult Delete(int ID)
        {
            _category_InterestLogic.DeleteCategoryInterest(ID);
            return RedirectToAction("Index");
        }

        //Create in CRUD
        [HttpGet]
        public ActionResult Create()
        {
            var categoryInterestViewModel = new Category_InterestViewModel();
            return View(categoryInterestViewModel);
        }

        [HttpPost]
        public ActionResult Create(Category_InterestViewModel categoryInterestViewModel)
        {
            _category_InterestLogic.CreateCategoryInterest(categoryInterestViewModel);

            return RedirectToAction("Index");
        }

        //Edit in CRUD
        [HttpGet]
        public ActionResult Edit()
        {
            var category_Interest = new Category_InterestViewModel();
            _category_InterestLogic.GetById(category_Interest);
            return View(category_Interest);
        }
        

        [HttpPost]
        public ActionResult Edit(Category_InterestViewModel category_Interest)
        {
            _category_InterestLogic.UpdateCategoryInterest(category_Interest);
            return RedirectToAction("Index");
        }

        public ActionResult AllMovies()
        {
            return View();
        }
    }
}