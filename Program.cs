namespace Wypozyczalnia_Filmow {
  internal class Program {
    

    public static void test_1() {
      
      var film = new Film("w pustyni", "al capone", "01-12-2021", 2, "krakow", EnumGatunek.Akcja);
      var klient = new Klient("MAREK", "KLICH", "222-111-000", "12345678910");
      Console.WriteLine(klient);
      
      var poprawnyNumerTelefonu = "123-456-789";
      klient.NumerTelefonu = poprawnyNumerTelefonu;
      Console.WriteLine(klient);
      
      var niepoprawnyNumerTelefonu = "555003882";
      klient.NumerTelefonu = niepoprawnyNumerTelefonu;
      Console.WriteLine(klient);
      
    }

    public static void TestZapisuDoPlikuXml() {
      var film1 = new Film("pustynia", "Capone", "01-12-2021", 2, "krakow", EnumGatunek.Akcja);
      Film.ZapiszFilmXml("/Users/marekklich/Desktop/filmy.xml", film1);
      Console.WriteLine(film1);
    }
    
    public static void TestZapisuZPlikuXml() {
      Console.WriteLine(Film.OdczytajFilmXml("/Users/marekklich/Desktop/filmy.xml"));
    }


    public static void test_2() {
      var wypozyczalnia = new WypozyczalniaFilmow();
      var film1 = new Film("w pustyni", "al capone", "01-12-2021", 2, "krakow", EnumGatunek.Akcja);
      wypozyczalnia.DodajFilm(film1);
      Console.WriteLine(wypozyczalnia);
    }

    
    
    public static void Main(string[] args) {
      
      
      // TestZapisuZPlikuXml();
      
      // test_2();
      
      // TestZapisuDoPlikuXml();
      
      // try {
      //   test_1();
      // }
      // catch (ZlyNumerTelefonuException e) {
      //   Console.WriteLine(e);
      // }
    }
  }
} 

