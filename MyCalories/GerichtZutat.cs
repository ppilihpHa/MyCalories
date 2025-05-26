using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyCalories
{
    public class GerichtZutat
    {
        [Key]
        public int GerichtZutatId { get; set; } //Primary
        public int GerichtId { get; set; }
        public int ZutatId { get; set; }
        public int menge { get; set; }

        public virtual Gericht Gericht { get; set; }
        public virtual Zutat Zutat { get; set; }
    }

    /*
     * 
     * 
        var zutatenListe = context.GerichtZutat
        .Where(gz => gz.GerichtId == gerichtId)
        .Select(gz => new
        {
            ZutatName = gz.Zutat.Name, 
            Menge = gz.Menge 
        }).ToList(); 
     * 
     */
}
