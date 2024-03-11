using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using WebApplication3.Models.roue;

namespace WebApplication3.Models
{
    public class Pneu
    {
        [Key]
        public int Id { get; set; }
        public List<MainsOeuvre> mainsOeuvres { get; set; }
        public List<Roue> roue { get; set; }
        public List<Gentes> gentes { get; set; }
        public List<Pneus> Pneus { get; set; }
    }
}
