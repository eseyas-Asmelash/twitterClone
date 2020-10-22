using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyTwitter.Data;
using MyTwitter.Models;
using MyTwitter.ViewModels;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MyTwitter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyDbContext _db;

        public HomeController(ILogger<HomeController> logger, MyDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            var model = new MessageViewModel();
            model.Messages = _db.Message.Where(a => a.User == User.Identity.Name).ToList();
            //List<PostMessage> msg = _db.Message.ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(PostMessage msg)
        {
            msg.User = User.Identity.Name;
            _db.Message.Add(msg);
            _db.SaveChanges();
            ModelState.Clear();
            //return View();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult UserPosted()
        {
            List<PostMessage> msg = _db.Message.Where(a => a.User == User.Identity.Name).ToList();
            //List<PostMessage> msg = _db.Message.ToList();
            return View(msg);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
