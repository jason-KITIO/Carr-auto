using Humanizer.Localisation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SendGrid.Helpers.Mail;
using WebApplication3.Data;
using WebApplication3.Data.enums;
using WebApplication3.Models;
using WebApplication3.Models.Produits;
using WebApplication3.Models.roue;

namespace WebApplication3.Controllers
{
    public class PneuController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PneuController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var viewModel = new Pneu
            {
                mainsOeuvres = await _context.mainsOeuvres.Take(4).ToListAsync(),
                roue = await _context.roue.Take(4).ToListAsync(),
                gentes = await _context.gentes.Take(4).ToListAsync(),
                Pneus = await _context.pneus.Take(4).ToListAsync(),
            };
            return View(viewModel);
        }

        #region Services

        [HttpPost]

        public IActionResult AddService(int id)
        {
            var nombre = _context.mainsOeuvres.Find(id);
            if (nombre != null)
            {
                nombre.nombre++;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult removeService(int id)
        {
            var nombre = _context.mainsOeuvres.Find(id);
            if (nombre != null)
            {
                if (nombre.nombre > 0)
                {
                    nombre.nombre--;
                }
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public IActionResult restartmainsOeuvres(int id)
        {
            var nombre = _context.mainsOeuvres.Find(id);
            if (nombre != null)
            {
                nombre.nombre = 0;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> moreServices()
        {
            var data = await _context.mainsOeuvres.ToListAsync();
            return View(data);
        }

        public IActionResult CreateServices()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateServices(MainsOeuvre mainsOeuvres)
        {
            if (!ModelState.IsValid)
            {
                if (_context.mainsOeuvres.Any(d => d.Id.Equals(mainsOeuvres.Id)))
                {
                    ViewBag.Erreur = "Cet auteur existe deja";
                    return View(mainsOeuvres);
                }
                _context.mainsOeuvres.Add(mainsOeuvres);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            return RedirectToAction(nameof(CreateServices));
        }
        public IActionResult EditServices(int id)
        {
            MainsOeuvre MainsOeuvre = _context.mainsOeuvres.FirstOrDefault(a => a.Id.Equals(id));
            if (MainsOeuvre == null)
            {
                return View("NotFound");
            }
            return View(MainsOeuvre);
        }
        [HttpPost]
        public IActionResult EditServices(MainsOeuvre mainsOeuvres)
        {
            if (_context.mainsOeuvres.Any(a => a.Id.Equals(mainsOeuvres.Id)))
            {
                _context.mainsOeuvres.Update(mainsOeuvres);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            ViewBag.Erreur = "Ce diplome n'existe pas";
            return RedirectToAction("index");

        }
        public IActionResult DetailsServices(int id)
        {
            var MainsOeuvreDetails = _context.mainsOeuvres.FirstOrDefault(a => a.Id == id);
            if (MainsOeuvreDetails == null)
            {
                return View("NotFound");
            }
            return View(MainsOeuvreDetails);
        }
        public IActionResult DeleteServices(int id)
        {
            MainsOeuvre MainsOeuvre = _context.mainsOeuvres.FirstOrDefault(d => d.Id.Equals(id));
            if (MainsOeuvre == null)
            {
                return NotFound();
            }
            return View(MainsOeuvre);
        }
        [HttpPost]
        public IActionResult DeleteServices(MainsOeuvre MainsOeuvre)
        {
            _context.mainsOeuvres.Remove(MainsOeuvre);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        #endregion

        #region Roue
        [HttpPost]
        public IActionResult AddRoue(int id)
        {
            var nombre = _context.roue.Find(id);
            if (nombre != null)
            {
                nombre.nombre++;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult removeRoue(int id)
        {
            var nombre = _context.roue.Find(id);
            if (nombre != null)
            {
                if (nombre.nombre > 0)
                {
                    nombre.nombre--;
                }
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult restartroue(int id)
        {
            var nombre = _context.roue.Find(id);
            if (nombre != null)
            {
                nombre.nombre = 0;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> moreRoue()
        {
            var data = await _context.roue.ToListAsync();
            return View(data);
        }


        public IActionResult CreateRoue()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRoue(Roue roue)
        {
            if (!ModelState.IsValid)
            {
                if (_context.roue.Any(d => d.Id.Equals(roue.Id)))
                {
                    ViewBag.Erreur = "Cet auteur existe deja";
                    return View(roue);
                }
                _context.roue.Add(roue);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            return RedirectToAction(nameof(CreateRoue));
        }
        public IActionResult EditRoue(int id)
        {
            Roue Roue = _context.roue.FirstOrDefault(a => a.Id.Equals(id));
            if (Roue == null)
            {
                return View("NotFound");
            }
            return View(Roue);
        }
        [HttpPost]
        public IActionResult EditRoue(Roue roue)
        {
            if (_context.roue.Any(a => a.Id.Equals(roue.Id)))
            {
                _context.roue.Update(roue);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            ViewBag.Erreur = "Ce diplome n'existe pas";
            return RedirectToAction("index");

        }
        public IActionResult DetailsRoue(int id)
        {
            var RoueDetails = _context.roue.FirstOrDefault(a => a.Id == id);
            if (RoueDetails == null)
            {
                return View("NotFound");
            }
            return View(RoueDetails);
        }
        public IActionResult DeleteRoue(int id)
        {
            Roue Roue = _context.roue.FirstOrDefault(d => d.Id.Equals(id));
            if (Roue == null)
            {
                return NotFound();
            }
            return View(Roue);
        }
        [HttpPost]
        public IActionResult DeleteRoue(Roue Roue)
        {
            _context.roue.Remove(Roue);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        #endregion

        #region Gentes
        [HttpPost]
        public IActionResult AddGentes(int id)
        {
            var nombre = _context.gentes.Find(id);
            if (nombre != null)
            {
                nombre.nombre++;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult removeGentes(int id)
        {
            var nombre = _context.gentes.Find(id);
            if (nombre != null)
            {
                if (nombre.nombre > 0)
                {
                    nombre.nombre--;
                }
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult restartgentes(int id)
        {
            var nombre = _context.gentes.Find(id);
            if (nombre != null)
            {
                nombre.nombre = 0;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> moreGentes()
        {
            var data = await _context.gentes.ToListAsync();
            return View(data);
        }

        public IActionResult CreateGentes()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateGentes(Gentes gentes)
        {
            if (!ModelState.IsValid)
            {
                if (_context.gentes.Any(d => d.Id.Equals(gentes.Id)))
                {
                    ViewBag.Erreur = "Cet auteur existe deja";
                    return View(gentes);
                }
                _context.gentes.Add(gentes);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            return RedirectToAction(nameof(CreateGentes));
        }
        public IActionResult EditGentes(int id)
        {
            Gentes Gentes = _context.gentes.FirstOrDefault(a => a.Id.Equals(id));
            if (Gentes == null)
            {
                return View("NotFound");
            }
            return View(Gentes);
        }
        [HttpPost]
        public IActionResult EditGentes(Gentes Gentes)
        {
            if (_context.gentes.Any(a => a.Id.Equals(Gentes.Id)))
            {
                _context.gentes.Update(Gentes);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            ViewBag.Erreur = "Ce diplome n'existe pas";
            return RedirectToAction("index");

        }
        public IActionResult DetailsGentes(int id)
        {
            var GentesDetails = _context.gentes.FirstOrDefault(a => a.Id == id);
            if (GentesDetails == null)
            {
                return View("NotFound");
            }
            return View(GentesDetails);
        }
        public IActionResult DeleteGentes(int id)
        {
            Gentes Gentes = _context.gentes.FirstOrDefault(d => d.Id.Equals(id));
            if (Gentes == null)
            {
                return NotFound();
            }
            return View(Gentes);
        }
        [HttpPost]
        public IActionResult DeleteGentes(Gentes Gentes)
        {
            _context.gentes.Remove(Gentes);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        #endregion

        #region Pneus
        [HttpPost]
        public IActionResult AddPneus(int id)
        {
            var nombre = _context.pneus.Find(id);
            if (nombre != null)
            {
                nombre.nombre++;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult removePneus(int id)
        {
            var nombre = _context.pneus.Find(id);
            if (nombre != null)
            {
                if (nombre.nombre > 0)
                {
                    nombre.nombre--;
                }
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult restartpneus(int id)
        {
            var nombre = _context.pneus.Find(id);
            if (nombre != null)
            {
                nombre.nombre = 0;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> morePneus()
        {
            var data = await _context.pneus.ToListAsync();
            return View(data);
        }

        public IActionResult CreatePneus()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreatePneus(Pneus pneus)
        {
            if (!ModelState.IsValid)
            {
                if (_context.pneus.Any(d => d.Id.Equals(pneus.Id)))
                {
                    ViewBag.Erreur = "Cet auteur existe deja";
                    return View(pneus);
                }
                _context.pneus.Add(pneus);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            return RedirectToAction(nameof(CreatePneus));
        }
        public IActionResult EditPneus(int id)
        {
            Pneus pneus = _context.pneus.FirstOrDefault(a => a.Id.Equals(id));
            if (pneus == null)
            {
                return View("NotFound");
            }
            return View(pneus);
        }
        [HttpPost]
        public IActionResult EditPneus(Pneus pneus)
        {
            if (_context.pneus.Any(a => a.Id.Equals(pneus.Id)))
            {
                _context.pneus.Update(pneus);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            ViewBag.Erreur = "Ce diplome n'existe pas";
            return RedirectToAction("index");

        }
        public IActionResult DetailsPneus(int id)
        {
            var PneusDetails = _context.pneus.FirstOrDefault(a => a.Id == id);
            if (PneusDetails == null)
            {
                return View("NotFound");
            }
            return View(PneusDetails);
        }
        public IActionResult DeletePneus(int id)
        {
            Pneus pneus = _context.pneus.FirstOrDefault(d => d.Id.Equals(id));
            if (pneus == null)
            {
                return NotFound();
            }
            return View(pneus);
        }
        [HttpPost]
        public IActionResult DeletePneus(Pneus pneus)
        {
            _context.pneus.Remove(pneus);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        #endregion
    }
}
