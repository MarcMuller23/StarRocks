using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StarRocks.Interfaces.Logic_Classes;
using StarRocks.Models;

namespace StarRocks.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryLogic _categoryLogic;

        public CategoryController(ICategoryLogic categoryLogic)
        {
            _categoryLogic = categoryLogic;
        }


        //Read in CRUD
        public ActionResult Index()
        {
            var allCategories = _categoryLogic.GetAllCategories();
            var categories = new List<CategoryViewModel>();

            foreach (var categorie in allCategories)
            {
                categories.Add(new CategoryViewModel
                {
                    //dasdasdasdasdasd
                });
            }
            return View(categories);
        }

        //Delete in CRUD
        public ActionResult Delete(int ID)
        {
            _categoryLogic.DeleteCategory(ID);
            return RedirectToAction("Index");
        }

        //Create in CRUD
        [HttpGet]
        public ActionResult Create()
        {
            var categoryViewModel = new CategoryViewModel();
            return View(categoryViewModel);
        }

        [HttpPost]
        public ActionResult Create(CategoryViewModel category)
        {
            _categoryLogic.CreateCategory(category);

            return RedirectToAction("Index");
        }

        //Edit in CRUD
        [HttpGet]
        public ActionResult Edit()
        {
            var category = new CategoryViewModel();
            _categoryLogic.GetById(category);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(CategoryViewModel category)
        {
            _categoryLogic.UpdateCategory(category);
            return RedirectToAction("Index");
        }

        public ActionResult AllMovies()
        {
            return View();
        }
    }
}
