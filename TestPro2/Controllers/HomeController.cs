using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TestPro2.DAL;
using TestPro2.Model;

namespace TestPro2.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Slider> sliders = _context.Sliders.ToList();
            return View(sliders);
        }
    }
}
