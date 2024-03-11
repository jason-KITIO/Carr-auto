using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Data.enums;
using WebApplication3.Models;
using WebApplication3.Models.Produits;

namespace WebApplication3.Controllers
{
    public class ProduitsController : Controller
    {
        public readonly ApplicationDbContext _context;
        public ProduitsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var viewModel = new Produit
            {
                batteries = await _context.batteries.Take(3).ToListAsync(),
                moteurs = await _context.moteurs.Take(3).ToListAsync(),
                suspensions = await _context.suspensions.Take(3).ToListAsync(),
                freins = await _context.freins.Take(3).ToListAsync(),
                turboCompresseur = await _context.turboCompresseur.Take(3).ToListAsync(),
            };
            return View(viewModel);
        }

        #region batteries
        [HttpPost]
        public IActionResult Addbatteries(int id)
        {
            var nombre = _context.batteries.Find(id);
            if (nombre != null)
            {
                nombre.nombre++;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult removebatteries(int id)
        {
            var nombre = _context.batteries.Find(id);
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
        public IActionResult restartbatteries(int id)
        {
            var nombre = _context.batteries.Find(id);
            if (nombre != null)
            {
                nombre.nombre = 0;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> moreBatterie()
        {

            var couleurs = Enum.GetValues(typeof(marque))
                               .Cast<marque>()
                               .Select(e => new SelectListItem
                               {
                                   Value = ((int)e).ToString(),
                                   Text = e.ToString()
                               });

            ViewBag.CouleursListe = couleurs;

            var categories = Enum.GetValues(typeof(marque)).Cast<marque>();
            ViewBag.Categories = new SelectList(categories);

            var data = await _context.batteries.ToListAsync();
            return View(data);
        }

        [HttpPost]
        public IActionResult AfficherParCategorieBatterie(marque categorie)
        {
            var categories = Enum.GetValues(typeof(marque)).Cast<marque>();
            ViewBag.Categories = new SelectList(categories);

            var produits = _context.batteries.Where(p => p.marque == categorie).ToList();
            if (produits.Count == 0)
            {
                return View("NotFound");
            }
            return View(produits);
        }

        #region Crud Batterie
        public IActionResult CreateBatterie()
            {
                return View();
            }
            [HttpPost]
            public async Task<IActionResult> CreateBatterie([Bind("image, prix, marque")] batterie batteries)
            {
                if (ModelState.IsValid)
                {
                    if (_context.batteries.Any(d => d.Id.Equals(batteries.Id)))
                    {
                        ViewBag.Erreur = "Cet auteur existe deja";
                        return View(batteries);
                    }
                    _context.batteries.Add(batteries);
                    _context.SaveChanges();
                    return RedirectToAction("index");
                }
                return RedirectToAction(nameof(CreateBatterie));
            }
            public IActionResult EditBatterie(int id)
            {
                batterie batteries = _context.batteries.FirstOrDefault(a => a.Id.Equals(id));
                if (batteries == null)
                {
                    return View("NotFound");
                }
                return View(batteries);
            }
            [HttpPost]
            public IActionResult EditBatterie(batterie batteries)
            {
                if (_context.batteries.Any(a => a.Id.Equals(batteries.Id)))
                {
                    _context.batteries.Update(batteries);
                    _context.SaveChanges();
                    return RedirectToAction("index");
                }
                ViewBag.Erreur = "Ce diplome n'existe pas";
                return RedirectToAction("index");

            }
            public IActionResult DetailsBatterie(int id)
            {
                var batterieDetails = _context.batteries.FirstOrDefault(a => a.Id == id);
                if (batterieDetails == null)
                {
                    return View("NotFound");
                }
                return View(batterieDetails);
            }
            public IActionResult DeleteBatterie(int id)
            {
                batterie batteries = _context.batteries.FirstOrDefault(d => d.Id.Equals(id));
                if (batteries == null)
                {
                    return NotFound();
                }
                return View(batteries);
            }
            [HttpPost]
            public IActionResult DeleteBatterie(batterie batteries)
            {
                _context.batteries.Remove(batteries);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
        #endregion
        #endregion

        #region moteurs
        [HttpPost]
        public IActionResult Addmoteurs(int id)
        {
            var nombre = _context.moteurs.Find(id);
            if (nombre != null)
            {
                nombre.nombre++;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult removemoteurs(int id)
        {
            var nombre = _context.moteurs.Find(id);
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
        public IActionResult restartmoteurs(int id)
        {
            var nombre = _context.moteurs.Find(id);
            if (nombre != null)
            {
                nombre.nombre = 0;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> moreMoteur()
        {
            var couleurs = Enum.GetValues(typeof(marque))
                               .Cast<marque>()
                               .Select(e => new SelectListItem
                               {
                                   Value = ((int)e).ToString(),
                                   Text = e.ToString()
                               });

            ViewBag.CouleursListe = couleurs;

            var categories = Enum.GetValues(typeof(marque)).Cast<marque>();
            ViewBag.Categories = new SelectList(categories);

            var data = await _context.moteurs.ToListAsync();
            return View(data);
        }

        [HttpPost]
        public IActionResult AfficherParCategorieMoteur(marque categorie)
        {
            var categories = Enum.GetValues(typeof(marque)).Cast<marque>();
            ViewBag.Categories = new SelectList(categories);

            var produits = _context.moteurs.Where(p => p.marque == categorie).ToList();
            if (produits.Count == 0)
            {
                return View("NotFound");
            }
            return View(produits);
        }

        #region Crud Moteur
        public IActionResult CreateMoteur()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateMoteur([Bind("image, prix, marque")] moteur moteurs)
        {
            if (ModelState.IsValid)
            {
                if (_context.moteurs.Any(d => d.Id.Equals(moteurs.Id)))
                {
                    ViewBag.Erreur = "Cet auteur existe deja";
                    return View(moteurs);
                }
                _context.moteurs.Add(moteurs);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            return RedirectToAction(nameof(CreateMoteur));
        }
        public IActionResult EditMoteur(int id)
        {
            moteur moteurs = _context.moteurs.FirstOrDefault(a => a.Id.Equals(id));
            if (moteurs == null)
            {
                return View("NotFound");
            }
            return View(moteurs);
        }
        [HttpPost]
        public IActionResult EditMoteur(moteur moteurs)
        {
            if (_context.moteurs.Any(a => a.Id.Equals(moteurs.Id)))
            {
                _context.moteurs.Update(moteurs);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            ViewBag.Erreur = "Ce diplome n'existe pas";
            return RedirectToAction("index");

        }
        public IActionResult DetailsMoteur(int id)
        {
            var moteurDetails = _context.moteurs.FirstOrDefault(a => a.Id == id);
            if (moteurDetails == null)
            {
                return View("NotFound");
            }
            return View(moteurDetails);
        }
        public IActionResult DeleteMoteur(int id)
        {
            moteur moteurs = _context.moteurs.FirstOrDefault(d => d.Id.Equals(id));
            if (moteurs == null)
            {
                return NotFound();
            }
            return View(moteurs);
        }
        [HttpPost]
        public IActionResult DeleteMoteur(moteur moteurs)
        {
            _context.moteurs.Remove(moteurs);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        #endregion
        #endregion

        #region TurboCompresseur
        [HttpPost]
        public IActionResult AddTurboCompresseur(int id)
        {
            var nombre = _context.turboCompresseur.Find(id);
            if (nombre != null)
            {
                nombre.nombre++;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult removeturboCompresseur(int id)
        {
            var nombre = _context.turboCompresseur.Find(id);
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
        public IActionResult restartturboCompresseur(int id)
        {
            var nombre = _context.turboCompresseur.Find(id);
            if (nombre != null)
            {
                nombre.nombre = 0;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> moreTurboCompresseur()
        {
            var couleurs = Enum.GetValues(typeof(marque))
                               .Cast<marque>()
                               .Select(e => new SelectListItem
                               {
                                   Value = ((int)e).ToString(),
                                   Text = e.ToString()
                               });

            ViewBag.CouleursListe = couleurs;

            var categories = Enum.GetValues(typeof(marque)).Cast<marque>();
            ViewBag.Categories = new SelectList(categories);

            var data = await _context.turboCompresseur.ToListAsync();
            return View(data);
        }
        [HttpPost]
        public IActionResult AfficherParCategorieTurboCompresseur(marque categorie)
        {
            var categories = Enum.GetValues(typeof(marque)).Cast<marque>();
            ViewBag.Categories = new SelectList(categories);

            var produits = _context.turboCompresseur.Where(p => p.marque == categorie).ToList();
            if (produits.Count == 0)
            {
                return View("NotFound");
            }
            return View(produits);
        }

        #region Crud TurboCompresseur
        public IActionResult CreateTurboCompresseur()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateTurboCompresseur([Bind("image, prix, marque")] TurboCompresseur turboCompresseur)
        {
            if (ModelState.IsValid)
            {
                if (_context.turboCompresseur.Any(d => d.Id.Equals(turboCompresseur.Id)))
                {
                    ViewBag.Erreur = "Cet auteur existe deja";
                    return View(turboCompresseur);
                }
                _context.turboCompresseur.Add(turboCompresseur);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            return RedirectToAction(nameof(CreateTurboCompresseur));
        }
        public IActionResult EditTurboCompresseur(int id)
        {
            TurboCompresseur turboCompresseur = _context.turboCompresseur.FirstOrDefault(a => a.Id.Equals(id));
            if (turboCompresseur == null)
            {
                return View("NotFound");
            }
            return View(turboCompresseur);
        }
        [HttpPost]
        public IActionResult EditTurboCompresseur(TurboCompresseur turboCompresseur)
        {
            if (_context.turboCompresseur.Any(a => a.Id.Equals(turboCompresseur.Id)))
            {
                _context.turboCompresseur.Update(turboCompresseur);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            ViewBag.Erreur = "Ce diplome n'existe pas";
            return RedirectToAction("index");

        }
        public IActionResult DetailsTurboCompresseur(int id)
        {
            var TurboCompresseurDetails = _context.turboCompresseur.FirstOrDefault(a => a.Id == id);
            if (TurboCompresseurDetails == null)
            {
                return View("NotFound");
            }
            return View(TurboCompresseurDetails);
        }
        public IActionResult DeleteTurboCompresseur(int id)
        {
            TurboCompresseur turboCompresseur = _context.turboCompresseur.FirstOrDefault(d => d.Id.Equals(id));
            if (turboCompresseur == null)
            {
                return NotFound();
            }
            return View(turboCompresseur);
        }
        [HttpPost]
        public IActionResult DeleteTurboCompresseur(TurboCompresseur turboCompresseur)
        {
            _context.turboCompresseur.Remove(turboCompresseur);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        #endregion
        #endregion

        #region suspensions
        [HttpPost]
        public IActionResult Addsuspensions(int id)
        {
            var nombre = _context.suspensions.Find(id);
            if (nombre != null)
            {
                nombre.nombre++;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult removesuspensions(int id)
        {
            var nombre = _context.suspensions.Find(id);
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
        public IActionResult restartsuspensions(int id)
        {
            var nombre = _context.suspensions.Find(id);
            if (nombre != null)
            {
                nombre.nombre = 0;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> moreSuspension()
        {
            var couleurs = Enum.GetValues(typeof(marque))
                               .Cast<marque>()
                               .Select(e => new SelectListItem
                               {
                                   Value = ((int)e).ToString(),
                                   Text = e.ToString()
                               });

            ViewBag.CouleursListe = couleurs;

            var categories = Enum.GetValues(typeof(marque)).Cast<marque>();
            ViewBag.Categories = new SelectList(categories);

            var data = await _context.suspensions.ToListAsync();
            return View(data);
        }

        [HttpPost]
        public IActionResult AfficherParCategorieSuspension(marque categorie)
        {
            var categories = Enum.GetValues(typeof(marque)).Cast<marque>();
            ViewBag.Categories = new SelectList(categories);

            var produits = _context.suspensions.Where(p => p.marque == categorie).ToList();
            if (produits.Count == 0)
            {
                return View("NotFound");
            }
            return View(produits);
        }

        #region Crud Suspension
        public IActionResult CreateSuspension()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateSuspension([Bind("image, prix, marque")] Suspension suspensions)
        {
            if (ModelState.IsValid)
            {
                if (_context.suspensions.Any(d => d.Id.Equals(suspensions.Id)))
                {
                    ViewBag.Erreur = "Cet auteur existe deja";
                    return View(suspensions);
                }
                _context.suspensions.Add(suspensions);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            return RedirectToAction(nameof(CreateSuspension));
        }
        public IActionResult EditSuspension(int id)
        {
            Suspension suspensions = _context.suspensions.FirstOrDefault(a => a.Id.Equals(id));
            if (suspensions == null)
            {
                return View("NotFound");
            }
            return View(suspensions);
        }
        [HttpPost]
        public IActionResult EditSuspension(Suspension suspensions)
        {
            if (_context.suspensions.Any(a => a.Id.Equals(suspensions.Id)))
            {
                _context.suspensions.Update(suspensions);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            ViewBag.Erreur = "Ce diplome n'existe pas";
            return RedirectToAction("index");

        }
        public IActionResult DetailsSuspension(int id)
        {
            var SuspensionDetails = _context.suspensions.FirstOrDefault(a => a.Id == id);
            if (SuspensionDetails == null)
            {
                return View("NotFound");
            }
            return View(SuspensionDetails);
        }
        public IActionResult DeleteSuspension(int id)
        {
            Suspension suspensions = _context.suspensions.FirstOrDefault(d => d.Id.Equals(id));
            if (suspensions == null)
            {
                return NotFound();
            }
            return View(suspensions);
        }
        [HttpPost]
        public IActionResult DeleteSuspension(Suspension suspensions)
        {
            _context.suspensions.Remove(suspensions);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        #endregion
        #endregion

        #region freins
        [HttpPost]
        public IActionResult Addfreins(int id)
        {
            var nombre = _context.freins.Find(id);
            if (nombre != null)
            {
                nombre.nombre++;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult removefreins(int id)
        {
            var nombre = _context.freins.Find(id);
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
        public IActionResult restartfreins(int id)
        {
            var nombre = _context.freins.Find(id);
            if (nombre != null)
            {
                nombre.nombre = 0;
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> morefreins()
        {
            var couleurs = Enum.GetValues(typeof(marque))
                               .Cast<marque>()
                               .Select(e => new SelectListItem
                               {
                                   Value = ((int)e).ToString(),
                                   Text = e.ToString()
                               });

            ViewBag.CouleursListe = couleurs;

            var categories = Enum.GetValues(typeof(marque)).Cast<marque>();
            ViewBag.Categories = new SelectList(categories);

            var data = await _context.freins.ToListAsync();
            return View(data);
        }
        [HttpPost]
        public IActionResult AfficherParCategoriefreins(marque categorie)
        {
            var categories = Enum.GetValues(typeof(marque)).Cast<marque>();
            ViewBag.Categories = new SelectList(categories);

            var produits = _context.freins.Where(p => p.marque == categorie).ToList();
            if (produits.Count == 0)
            {
                return View("NotFound");
            }
            return View(produits);
        }

        #region Crud freins
        public IActionResult Createfreins()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Createfreins([Bind("image, prix, marque")] freins freins)
        {
            if (ModelState.IsValid)
            {
                if (_context.freins.Any(d => d.Id.Equals(freins.Id)))
                {
                    ViewBag.Erreur = "Cet auteur existe deja";
                    return View(freins);
                }
                _context.freins.Add(freins);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            return RedirectToAction(nameof(Createfreins));
        }
        public IActionResult Editfreins(int id)
        {
            freins freins = _context.freins.FirstOrDefault(a => a.Id.Equals(id));
            if (freins == null)
            {
                return View("NotFound");
            }
            return View(freins);
        }
        [HttpPost]
        public IActionResult Editfreins(freins freins)
        {
            if (_context.freins.Any(a => a.Id.Equals(freins.Id)))
            {
                _context.freins.Update(freins);
                _context.SaveChanges();
                return RedirectToAction("index");
            }
            ViewBag.Erreur = "Ce diplome n'existe pas";
            return RedirectToAction("index");

        }
        public IActionResult Detailsfreins(int id)
        {
            var freinsDetails = _context.freins.FirstOrDefault(a => a.Id == id);
            if (freinsDetails == null)
            {
                return View("NotFound");
            }
            return View(freinsDetails);
        }
        public IActionResult Deletefreins(int id)
        {
            freins freins = _context.freins.FirstOrDefault(d => d.Id.Equals(id));
            if (freins == null)
            {
                return NotFound();
            }
            return View(freins);
        }
        [HttpPost]
        public IActionResult Deletefreins(freins freins)
        {
            _context.freins.Remove(freins);
            _context.SaveChanges();
            return RedirectToAction("index");
        }
        #endregion
        #endregion
    }
}
