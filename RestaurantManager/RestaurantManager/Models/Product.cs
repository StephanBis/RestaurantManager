using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public int CategorieId { get; set; }
        public string Naam { get; set; }
        public decimal Prijs { get; set; }
    }
}
