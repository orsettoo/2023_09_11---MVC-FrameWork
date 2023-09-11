using Microsoft.AspNetCore.Mvc;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class Kisiler2Controller : Controller
    {
        private readonly MyDbContext _context;
        public Kisiler2Controller(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var query = from k in _context.Kisiler
                        orderby k.Adi
                        select new KisiViewModel
                        {
                            Id = k.Id,
                            TamAdi = k.TamAdi
                        };

            return View(query.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
