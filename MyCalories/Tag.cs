using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyCalories
{
    public class Tag
    {
        [Key]
        public int TagId { get; set; }

        public DateTime Zeitpunkt { get; set; }
        public float TagZuCal { get; set; }
        public float TagZuEiw { get; set; }
        public float TagZuMenge { get; set; }
        public int ZutatId { get; set; }

        
        public virtual Zutat Zutat { get; set; }

        public string ZutatName
        {
            get { return Zutat?.name; }
        }
    }
}
