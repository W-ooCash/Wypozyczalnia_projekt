using System;
using System.Text;
using System.Xml.Serialization;

namespace Wypozyczalnia_Filmow {
    public class WypozyczalniaFilmow{

        private Dictionary<string, Film> filmyDictionary = new Dictionary<string, Film>();
        private Dictionary<string, Klient> klienciDictionary = new Dictionary<string, Klient>();
        
        

        // public WypozyczalniaFilmow(string tytul, string rezyser, string dataPremiery, int liczbaKopii, 
        //     string miejsceProdukcji, EnumGatunek gatunek) : base(tytul, rezyser, dataPremiery, liczbaKopii, miejsceProdukcji, gatunek){
        // }
        
        //lista klientow
        //Add customer
        //wylistuj klientów
        // usun klienta
        //Search a movie
        // Show all movies
        //Add a movie record
        // Edit movie record
        // delete movie record
        //sortuj abonentow

        //Rent
        //return
        


        //metody kla filmow

        public List<Film> WyszukajFilm(string tytul) {
            return filmyDictionary.Values.Where(film => film.tytul.Contains(tytul)).ToList();
        }

        public void DodajFilm(Film film) {
            filmyDictionary.Add(film.tytul, film);
            
        }

        //przypisac te metody do klienta?
        public void WypozyczFilm() {
            
        }

        public void OddajFilm() {
            
        }
        
        public void WylistujWszystkieFilmy() {
            
        }

        public void WylistujWszystkichKlientow() {
            
        }
        
        
        
        //metody dla klientow
        
        public List<Klient> WyszukajKlienta(string pesel) {
            return klienciDictionary.Values.Where(klient => klient.pesel.Contains(pesel)).ToList();
        }
        


        public void UsunKlienta() {
            
        }

        
        public override string ToString() {
            var sb = new StringBuilder("filmy:\n");
            foreach (var film in filmyDictionary) sb.AppendLine(film.Value.ToString());
            return base.ToString() + "\n" + sb;
        }
    }
}

