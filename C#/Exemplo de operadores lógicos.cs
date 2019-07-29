using System;

namespace AplicacaoOperadores {
   class Program {
      static void Main(string[] args) {
         bool a = true; 
         bool b = true;
         
         if (a && b) {
            Console.WriteLine("Linha 1 - Consição é verdadeira");
         }
         
         if (a || b) {
            Console.WriteLine("Linha 2 - Condição é verdadeira");
         }
         
         /* Trocando os valores de a e b */
         a = false;
         b = true;
         
         if (a && b) {
            Console.WriteLine("Linha 3 - Condição é verdadeira");
         } else {
            Console.WriteLine("Linha 3 - Condição é falsa");
         }
         
         if (!(a && b)) {
            Console.WriteLine("Linha 4 - Condição é verdadeira");
         }
         Console.ReadLine();
      }
   }
}
