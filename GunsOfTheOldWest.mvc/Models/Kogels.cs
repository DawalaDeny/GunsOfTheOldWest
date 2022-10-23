using System.Diagnostics;

namespace GunsOfTheOldWest.mvc.Models
{
    public class Kogels
    {
        public int aantalKogels { get; set; }

        public Kogels()
        {
            aantalKogels = 12;
        }

        public void Schiet()
        {
            aantalKogels--;
        }

        public void Reset()
        {
            aantalKogels = 12;
        }

        public void Kopen(int aantal)
        {
            aantalKogels += aantal;
        }
    }
}
