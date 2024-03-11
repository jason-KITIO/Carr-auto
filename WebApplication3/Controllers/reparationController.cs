using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Data.enums;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class reparationController : Controller
    {
        private readonly ApplicationDbContext _context;
        public reparationController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var couleurs = Enum.GetValues(typeof(categorieVoiture))
                               .Cast<categorieVoiture>()
                               .Select(e => new SelectListItem
                               {
                                   Value = ((int)e).ToString(),
                                   Text = e.ToString()
                               });

            ViewBag.CouleursListe = couleurs;

            var categories = Enum.GetValues(typeof(categorieVoiture)).Cast<categorieVoiture>();
            ViewBag.Categories = new SelectList(categories);

            var data = await _context.reparations.ToListAsync();
            return View(data);
        }

        [HttpPost]
        public IActionResult AfficherParCategorie(categorieVoiture categorie)
        {
            var categories = Enum.GetValues(typeof(categorieVoiture)).Cast<categorieVoiture>();
            ViewBag.Categories = new SelectList(categories);

            var produits = _context.reparations.Where(p => p.categorie == categorie).ToList();
            if (produits.Count == 0)
            {
                return View("NotFound");
            }
            return View(produits);
        }

        [HttpPost]
        public IActionResult restart(int id)
        {
            var nombre = _context.reparations.Find(id);
            if (nombre != null)
            {
                nombre.nombre = 0;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        #region Crud 
        public IActionResult CreateReparation()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateReparation(Reparation reparations)
        {
            if (!ModelState.IsValid)
            {
                if (_context.reparations.Any(d => d.Id.Equals(reparations.Id)))
                {
                    ViewBag.Erreur = "Cet auteur existe deja";
                    return View(reparations);
                }
                _context.reparations.Add(reparations);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            return RedirectToAction(nameof(CreateReparation));
        }
        public IActionResult EditReparation(int id)
        {
            Reparation reparations = _context.reparations.FirstOrDefault(a => a.Id.Equals(id));
            if (reparations == null)
            {
                return View("NotFound");
            }
            return View(reparations);
        }
        [HttpPost]
        public IActionResult EditReparation(Reparation reparations)
        {
            if (_context.reparations.Any(a => a.Id.Equals(reparations.Id)))
            {
                _context.reparations.Update(reparations);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            ViewBag.Erreur = "Ce diplome n'existe pas";
            return RedirectToAction("index");

        }
        public IActionResult DetailsReparation(int id)
        {
            var ReparationDetails = _context.reparations.FirstOrDefault(a => a.Id == id);
            if (ReparationDetails == null)
            {
                return View("NotFound");
            }
            return View(ReparationDetails);
        }
        public IActionResult DeleteReparation(int id)
        {
            Reparation reparations = _context.reparations.FirstOrDefault(d => d.Id.Equals(id));
            if (reparations == null)
            {
                return NotFound();
            }
            return View(reparations);
        }
        [HttpPost]
        public IActionResult DeleteReparation(Reparation reparations)
        {
            _context.reparations.Remove(reparations);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        #endregion
    }
}
