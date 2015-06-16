using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantManager
{
    public class RMDB : DbContext
    {
        public RMDB()
            : base("name=RMDB")
        {
        }

        public virtual DbSet<Gebruiker> Gebruikers { get; set; }
        public virtual DbSet<Tafel> Tafels { get; set; }
    }
}