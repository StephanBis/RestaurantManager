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

        #region gebruiker
        public static Gebruiker GetUserByName(string gebruikersnaam)
        {
            return _db.Gebruikers.FirstOrDefault(g => g.Gebruikersnaam == gebruikersnaam);
        }

        public static List<Gebruiker> GetGebruikers()
        {
            return _db.Gebruikers.ToList();
        }

        public static Gebruiker GetGebruikerById(int id)
        {
            return _db.Gebruikers.FirstOrDefault(g => g.GebruikerId == id);
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
        #endregion

        #region tafel
        public static List<Tafel> GetTafels()
        {
            return _db.Tafels.ToList();
        }

        public static Tafel GetTafelById(int id)
        {
            return _db.Tafels.FirstOrDefault(g => g.TafelId == id);
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
        #endregion

        #region categorie
        public static List<Categorie> GetCategorien()
        {
            return _db.Categorien.ToList();
        }

        public static Categorie GetCategorieById(int id)
        {
            return _db.Categorien.FirstOrDefault(g => g.CategorieId == id);
        }

        public static void EditCategorie(Categorie categorie)
        {
            Categorie oudeCategorie = GetCategorieById(categorie.CategorieId);
            oudeCategorie.Naam = categorie.Naam;
            _db.SaveChanges();
        }

        public static void InsertCategorie(Categorie categorie)
        {
            _db.Categorien.Add(categorie);
            _db.SaveChanges();
        }

        public static void DeleteCategorie(Categorie categorie)
        {
            _db.Categorien.Remove(categorie);
            _db.SaveChanges();
        }
        #endregion

        #region product
        public static List<Product> GetProducten()
        {
            return _db.Producten.ToList();
        }

        public static Product GetProductById(int id)
        {
            return _db.Producten.FirstOrDefault(g => g.ProductId == id);
        }

        public static List<Product> GetProductenByCategorie(int categorieId)
        {
            return _db.Producten.Where(g => g.CategorieId == categorieId).ToList();
        }

        public static void EditProduct(Product product)
        {
            Product oudeproduct = GetProductById(product.ProductId);
            oudeproduct.Naam = product.Naam;
            oudeproduct.Prijs = product.Prijs;
            oudeproduct.CategorieId = product.CategorieId;
            _db.SaveChanges();
        }

        public static void InsertProduct(Product product)
        {
            _db.Producten.Add(product);
            _db.SaveChanges();
        }

        public static void DeleteProduct(Product product)
        {
            _db.Producten.Remove(product);
            _db.SaveChanges();
        }
        #endregion
    }
}
