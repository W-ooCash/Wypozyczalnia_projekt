using System;
namespace Wypozyczalnia_Filmow {
 
    public class ZlyPeselException : Exception  {
        
        public ZlyPeselException(string message) : base(message) {
            
        }
    }
}