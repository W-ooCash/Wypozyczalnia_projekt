using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace Wypozyczalnia_Filmow { //poprawic exceptions, wywala tylko przy zmianie, zrobic tak jak date

    public class Klient {
        public string imie; 
        public string nazwisko;
        public string numerTelefonu;
        public string pesel; 
        public static int id;
        
        
        public Klient(string imie, string nazwisko, string numerTelefonu, string pesel) {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.numerTelefonu = numerTelefonu;
            this.pesel = pesel;
            id++;
            
        }



        public string NumerTelefonu {
            get => numerTelefonu;
            set {
                if (SprawdzNumer(value)) {
                    numerTelefonu = value;
                }else {
                    throw new ZlyNumerTelefonuException("Zly numer telefonu, wpisz w takiej formie ccc-ccc-ccc"); 
                }
            }
        }
        

        public String Pesel {
            get => pesel;
            set {
                if (SprawdzPesel(value)) {
                    pesel = value;
                }
                else {
                    throw new ZlyPeselException("Zly numer pesel, powinien miec 11 cyfr");
                }
            }
        }
        

        

        public bool SprawdzNumer(string numer) {
            var format = @"^\d{3}-\d{3}-\d{3}$";
            return Regex.IsMatch(numer, format);
        }


        public bool SprawdzPesel(string pesel) {
            return Regex.IsMatch(pesel, @"^\d{11}$");
        }



        public override string ToString() {
            return $"Imie:{imie}| Nazwisko:{nazwisko}| Numer Telefonu:{numerTelefonu}| Pesel:{pesel}| Id:{id}| ";
        }
        
        
        
        
        
    }
}

