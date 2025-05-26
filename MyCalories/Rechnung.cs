using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalories
{
    public class Rechnung
    {
        public Rechnung(string nameAngeben, float mengeAngeben, float kalAngeben, float eiwAngeben)
        {
            name = nameAngeben;
            menge = mengeAngeben;
            kalorien = kalAngeben;
            eiweiß = eiwAngeben;
        }
        public string name { get; set; }
        public float menge { get; set; }
        public float kalorien { get; set; }
        public float eiweiß {  get; set; }
    }
}
