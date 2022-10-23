using System.ComponentModel.DataAnnotations;

namespace GunsOfTheOldWest.mvc.Models
{
    public class Speler
    {
        [Required]
        public string voornaam { get; set; }
        [Required]
        public string naam { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [Required]
        public string telefoon { get; set; }

        public DateTime Date = DateTime.Now;
        public Speler(string vn, string nm, string em, string te)
        {
            this.voornaam = vn;
            this.naam = nm;
            this.email = em;
            this.telefoon = te;
            
        }


    }
}
