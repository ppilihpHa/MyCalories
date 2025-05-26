using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyCalories
{
    public class Gericht
    {
        [Key]
        public int GerichtId { get; set; }

        public String name { get; set; }
        public float kal { get; set; }
        public float eiw { get; set; }
        public float menge { get; set; }

        public virtual ICollection<GerichtZutat> GerichtZutats { get; set; }

        public Gericht()
        {
            GerichtZutats = new HashSet<GerichtZutat>(); //Liste
        }

        public List<(Zutat, int)> ZutatenMitMengen
        {
            get { return GerichtZutats.Select(gz => (gz.Zutat, gz.menge)).ToList(); }
        }

    }
}
