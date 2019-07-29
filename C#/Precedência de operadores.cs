using System;

namespace AplicacaoOperadores {
   class Programa {
      static void Main(string[] args) {
         int a = 20;
         int b = 10;
         int c = 15;
         int d = 5;
         int e;

         e = (a + b) * c / d;
         Console.WriteLine("O valor de (a + b) * c / d é : {0}", e);

         e = ((a + b) * c) / d;
         Console.WriteLine("O valor de ((a + b) * c) / d é  : {0}", e);

         e = (a + b) * (c / d);   // (30) * (15/5) = 90

         e = a + (b * c) / d;    //  20 + (150/5) = 50
         Console.ReadLine();
      }
   }
}
