using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SendGrid.Helpers.Mail;
using WebApplication3.Data;
using WebApplication3.Models;
using WebApplication3.Models.roue;

namespace WebApplication3.Controllers
{
    public class DevisController : Controller
    {
        private readonly ApplicationDbContext _context;
        public DevisController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var viewModel = new devis
            {
                Pneus = await _context.pneus.ToListAsync(),
                roue = await _context.roue.ToListAsync(),
                gentes = await _context.gentes.ToListAsync(),
                mainsOeuvres = await _context.mainsOeuvres.ToListAsync(),
                Voiture = await _context.voitures.ToListAsync(),

                turboCompresseur = await _context.turboCompresseur.ToListAsync(),
                suspensions = await _context.suspensions.ToListAsync(),
                moteurs = await _context.moteurs.ToListAsync(),
                batteries = await _context.batteries.ToListAsync(),

                reparations = await _context.reparations.ToListAsync(),
            };

            return View(viewModel);
        }
        public async Task<IActionResult> imprimer()
        {
            return View();
        }
    }
}
