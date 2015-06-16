using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Tafel
    {
        [Key]
        public int TafelId { get; set; }
        public string TafelNummer { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public string Kleur { get; set; }
    }
}
