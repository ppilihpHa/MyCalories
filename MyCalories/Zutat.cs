using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyCalories
{
    public class Zutat
    {
        public enum Kategorie
        {
            Getränk,
            Milchprodukte,
            Obst_Gemüse,
            Beilage,
            Fleisch_Fisch,
            Gericht,
            Sonstiges,
            Süßigkeiten,
            Kuchen,
            Suppen_Vorspeisen,
            Nachspeisen,
            Backwaren
        }

        [Key]
        public int ZutatId { get; set; } //Primary

        public String name { get; set; }
        public float eiweiß { get; set; }
        public float kalorien { get; set; }
        public int gewicht { get; set; }

        public Kategorie kategorie { get; set;}

        public virtual ICollection<Tag> Tags { get; set; }

        public virtual ICollection<GerichtZutat> GerichtZutats { get; set; }

        public Zutat()
        {
            GerichtZutats = new HashSet<GerichtZutat>(); // Liste
        }
    }
}
