using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;

namespace WebApplication3.Controllers
{
    // Contrôleur
    public class NombreController : Controller
    {
        private readonly ApplicationDbContext _context;

        public NombreController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var nombres = _context.Nombres.ToList();
            return View(nombres);
        }

        [HttpPost]
        public IActionResult Incrementer(int id)
        {
            var nombre = _context.Nombres.Find(id);
            if (nombre != null)
            {
                nombre.Nombre++;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult decrementer(int id)
        {
            var nombre = _context.Nombres.Find(id);
            if (nombre != null)
            {
                nombre.Nombre--;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
