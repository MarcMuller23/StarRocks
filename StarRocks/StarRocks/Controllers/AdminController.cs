using Microsoft.AspNetCore.Mvc;

namespace RockStarsInlog.Controllers
{
    public class AdminController : Controller
    {

        public IActionResult AdminProfile()
        {
            return View();
        }

        public IActionResult AdminInbox()
        {
            return View();
        }

        public IActionResult AdminEvents()
        {
            return View();
        }

        public IActionResult AdminFav()
        {
            return View();
        }

        public IActionResult AdminMaps()
        {
            return View();
        }

        public IActionResult AdminSent()
        {
            return View();
        }

        public IActionResult AdminTrash()
        {
            return View();
        }
    }
}