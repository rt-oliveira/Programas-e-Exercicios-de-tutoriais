using System;

namespace Lacos {
   class Program {
      static void Main(string[] args) {
         int a = 10;
         
         /* Execução do laço 'do..while'.
            Esse laço será feito, *pelo menos*, uma vez, no mínimo. 
            Essa é a principal diferença para o 'while', que não há essa garantia.
         */
         do {
            Console.WriteLine("Valor de a: {0}", a);
            a = a + 1;
         } 
         while (a < 20);
         Console.ReadLine();
      }
   }
} 