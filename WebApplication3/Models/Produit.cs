using System.ComponentModel.DataAnnotations;
using System.Composition.Convention;
using WebApplication3.Models.Produits;

namespace WebApplication3.Models
{
    public class Produit
    {
        [Key]
        public int Id { get; set; }
        public List<freins> freins { get; set; }
        public List<batterie> batteries { get; set; }
        public List<moteur> moteurs { get; set;}
        public List<Suspension> suspensions { get; set; }
        public List<TurboCompresseur> turboCompresseur { get; set; }
    }
}
