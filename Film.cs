using System;
using System.Xml.Serialization;

namespace Wypozyczalnia_Filmow {
    
    [Serializable]
    public enum EnumGatunek {
        Przygodowy,
        Akcja,
        Komedia,
        Kryminal,
        Dokumentalny
    }

    public class Film {
        public static long indeks;
        public string tytul;
        public string rezyser;
        public DateTime dataPremiery;
        public static int liczbaKopii; 
        public string miejsceProdukcji;
        public EnumGatunek gatunek;
        //public bool czyJestWypozyczony;
        

        public DateTime DataPremiery {
            get => dataPremiery;
            set => dataPremiery = value;
        }

        public int LiczbaKopii {
            get => liczbaKopii;
            set => liczbaKopii = value;
        }


        static Film() {
            indeks = 1;
            liczbaKopii = 2;
        }
        
        public Film(){}

        //przy wypozyczeniu obnizyc liczbe kopii, sprawdzic czy liczba kopii >1 przy wypożyczeniu //albo wyrzucic liczbe kopii
        public Film(string tytul, string rezyser, string dataPremiery, int liczbaKopii, string miejsceProdukcji, EnumGatunek gatunek) {
            this.tytul = tytul;
            this.rezyser = rezyser;
            this.miejsceProdukcji = miejsceProdukcji;
            this.gatunek = gatunek;

            indeks++;
            liczbaKopii--;
            

            if (DateTime.TryParseExact(dataPremiery, new string[] { "dd-MM-yyyy", "yyyy-MM-dd", "dd/MM/yyyy", "yyyy/MM/dd" },
                    null, System.Globalization.DateTimeStyles.None, out DateTime data)) {
                DataPremiery = data;
            }
            else {
                throw new ZlaDataException("Wprowadz poprawna date: dd-MM-yyyy, yyyy-MM-dd, dd/MM/yyyy, yyyy/MM/dd");
            }
            
        }
        
        //Serializacja XML
        public static void ZapiszFilmXml(string sciezkaPliku, Film filmDoWpisania){
            XmlSerializer serializer = new XmlSerializer(typeof(Film));
            StreamWriter writer = new StreamWriter(sciezkaPliku);
            serializer.Serialize(writer, filmDoWpisania);
            writer.Close();
        }
        
        
        //Deserializacja XML
        public static Film OdczytajFilmXml(string sciezkaPliku) {
            try {
                StreamReader stream = new StreamReader(sciezkaPliku);
                XmlSerializer serializer = new XmlSerializer(typeof(Film));
                Film filmZpliku = (Film)serializer.Deserialize(stream);
                stream.Close();
                return filmZpliku;
            }
            catch (FileNotFoundException){
                Console.WriteLine("Plik {0} o danej sciezce nie istnieje", sciezkaPliku);
            }
            return null;
        }


        public override string ToString() {
            return $" Indeks:{indeks}| Tytul:{tytul}| Rezyser:{rezyser}| Data Premiery:{dataPremiery:yyy-MM-dd}| Liczba Kopii:{liczbaKopii}| " +
                   $"Miejsce Produkcji:{miejsceProdukcji}| Gatunek:{gatunek}" ;
        }
        
        
    }
}







    

    
    
    
    
    
    
    












