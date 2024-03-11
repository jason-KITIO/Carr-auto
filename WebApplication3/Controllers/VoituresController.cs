using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SendGrid.Helpers.Mail;
using WebApplication3.Data;
using WebApplication3.Data.enums;
using WebApplication3.Models;
using WebApplication3.Models.roue;

namespace WebApplication3.Controllers
{
    public class VoituresController : Controller
    {
        private readonly ApplicationDbContext _context;
        public VoituresController(ApplicationDbContext context)
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

            var data = await _context.voitures.Take(6).ToListAsync();
            return View(data);
        }
        public async Task<IActionResult> more()
        {

            //var categories = Enum.GetValues(typeof(categorieVoiture))
            //                     .Cast<categorieVoiture>()
            //                     .Select(c => new SelectListItem
            //                     {
            //                         Value = ((int)c).ToString(),
            //                         Text = c.ToString()
            //                     });

            //ViewBag.Categories = categories;

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


            var data = await _context.voitures.ToListAsync();
            return View(data);

        }

        [HttpPost]
        public IActionResult AfficherParCategorie(categorieVoiture categorie)
        {
            var categories = Enum.GetValues(typeof(categorieVoiture)).Cast<categorieVoiture>();
            ViewBag.Categories = new SelectList(categories);

            var produits = _context.voitures.Where(p => p.categorie == categorie).ToList();
            if (produits.Count == 0)
            {
                return View("NotFound");
            }
            return View(produits);
        }

        [HttpPost]
        public IActionResult restart(int id)
        {
            var nombre = _context.voitures.Find(id);
            if (nombre != null)
            {
                nombre.nombre = 0;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        #region Voiture
        [HttpPost]
        public async Task<IActionResult> AddVoiture(int id)
        {
            var nombre = await _context.voitures.FindAsync(id);
            if (nombre != null)
            {   
                nombre.nombre++;
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult removeVoiture(int id)
        {
            var nombre = _context.voitures.Find(id);
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
        #endregion

        #region Crud 
        public IActionResult CreateVoiture()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateVoiture(Voiture voitures)
        {
            if (!ModelState.IsValid)
            {
                if (_context.voitures.Any(d => d.Id.Equals(voitures.Id)))
                {
                    ViewBag.Erreur = "Cet auteur existe deja";
                    return View(voitures);
                }
                _context.voitures.Add(voitures);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            return RedirectToAction(nameof(CreateVoiture));
        }
        public IActionResult EditVoiture(int id)
        {
            Voiture Voiture = _context.voitures.FirstOrDefault(a => a.Id.Equals(id));
            if (Voiture == null)
            {
                return View("NotFound");
            }
            return View(Voiture);
        }
        [HttpPost]
        public IActionResult EditVoiture(Voiture Voiture)
        {
            if (_context.voitures.Any(a => a.Id.Equals(Voiture.Id)))
            {
                _context.voitures.Update(Voiture);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            ViewBag.Erreur = "Ce diplome n'existe pas";
            return RedirectToAction("index");

        }
        public IActionResult DetailsVoiture(int id)
        {
            var VoitureDetails = _context.voitures.FirstOrDefault(a => a.Id == id);
            if (VoitureDetails == null)
            {
                return View("NotFound");
            }
            return View(VoitureDetails);
        }
        public IActionResult DeleteVoiture(int id)
        {
            Voiture Voiture = _context.voitures.FirstOrDefault(d => d.Id.Equals(id));
            if (Voiture == null)
            {
                return NotFound();
            }
            return View(Voiture);
        }
        [HttpPost]
        public IActionResult DeleteVoiture(Voiture Voiture)
        {
            _context.voitures.Remove(Voiture);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        #endregion
    }
}
