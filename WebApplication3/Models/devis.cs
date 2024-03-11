using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WebApplication3.Models.Produits;
using WebApplication3.Models.roue;

namespace WebApplication3.Models
{
    public class devis
    {
        [Key]
        public int Id { get; set; }
        public int iDmainsOeuvres { get; set; }
        public int iDroue { get; set; }
        public int iDgentes { get; set; }
        public int iDPneus { get; set; }
        public int iDVoiture { get; set; }

        public List<MainsOeuvre> mainsOeuvres { get; set; }
        public List<Roue> roue { get; set; }
        public List<Gentes> gentes { get; set; }
        public List<Pneus> Pneus { get; set; }
        public List<Voiture> Voiture { get; set; }



        public int iDFreins { get; set; }
        public int iDbatteries { get; set; }
        public int iDmoteurs { get; set; }
        public int iDsuspensions { get; set; }
        public int iDturboCompresseur { get; set; }

        public List<freins> freins { get; set; }
        public List<batterie> batteries { get; set; }
        public List<moteur> moteurs { get; set; }
        public List<Suspension> suspensions { get; set; }
        public List<TurboCompresseur> turboCompresseur { get; set; }

        public int iDReparation{ get; set; }
        public List<Reparation> reparations { get; set; }

    }
}
