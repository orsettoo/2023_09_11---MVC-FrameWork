using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class UserManagerController : Controller
    {
        private static List<UserModel> userList = new List<UserModel>()
        {
            new UserModel {Name="rr",Surname="aa",Age=12},
            new UserModel {Name="tt",Surname="bb",Age=56},
            new UserModel {Name="u",Surname="cc",Age=23},
            new UserModel {Name="jj",Surname="dd",Age=35},
        };

        //[HttpGet]
        public IActionResult Index()
        {
            return View(userList);
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(UserModel model)
        {
            userList.Add(model);
            return RedirectToAction("Index");
        }


    }
}
