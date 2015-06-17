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

        public static List<Gebruiker> GetGebruikers()
        {
            return _db.Gebruikers.ToList();
        }

        public static Tafel GetTafelById(int id)
        {
            return _db.Tafels.FirstOrDefault(g => g.TafelId == id);
        }

        public static Gebruiker GetGebruikerById(int id)
        {
            return _db.Gebruikers.FirstOrDefault(g => g.GebruikerId == id);
        }

        public static void EditTafel(Tafel tafel)
        {
            Tafel oudeTafel = GetTafelById(tafel.TafelId);
            oudeTafel.TafelNummer = tafel.TafelNummer;
            oudeTafel.Kleur = tafel.Kleur;
            _db.SaveChanges();
        }

        public static void InsertTafel(Tafel tafel)
        {
            _db.Tafels.Add(tafel);
            _db.SaveChanges();
        }

        public static void DeleteTafel(Tafel tafel)
        {
            _db.Tafels.Remove(tafel);
            _db.SaveChanges();
        }

        public static void EditGebruiker(Gebruiker gebruiker)
        {
            Gebruiker oudeGebruiker = GetGebruikerById(gebruiker.GebruikerId);
            oudeGebruiker.Gebruikersnaam = gebruiker.Gebruikersnaam;
            oudeGebruiker.Wachtwoord = gebruiker.Wachtwoord;
            oudeGebruiker.Rol = gebruiker.Rol;
            _db.SaveChanges();
        }

        public static void InsertGebruiker(Gebruiker gebruiker)
        {
            _db.Gebruikers.Add(gebruiker);
            _db.SaveChanges();
        }

        public static void DeleteGebruiker(Gebruiker gebruiker)
        {
            _db.Gebruikers.Remove(gebruiker);
            _db.SaveChanges();
        }
    }
}
