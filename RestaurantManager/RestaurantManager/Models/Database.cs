using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManager
{
    public class Database
    {
        private static RMDB _db = new RMDB();

        public static Gebruiker GetUserByName(string gebruikersnaam)
        {
            return _db.Gebruikers.FirstOrDefault(g => g.Gebruikersnaam == gebruikersnaam);
        } 

        public static List<Tafel> GetTafels()
        {
            return _db.Tafels.ToList();
        }

        public static Tafel GetTafelById(int id)
        {
            return _db.Tafels.FirstOrDefault(g => g.TafelId == id);
        }
    }
}
