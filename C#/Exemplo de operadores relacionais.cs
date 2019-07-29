using System;

class Programa {
   static void Main(string[] args) {
      int a = 21;
      int b = 10;
      
      if (a == b) {
         Console.WriteLine("Linha 1 - a é igual a b");
      } else {
         Console.WriteLine("Linha 1 - a não é igual a b");
      }
      
      if (a < b) {
         Console.WriteLine("Linha 2 - a é menor que b");
      } else {
         Console.WriteLine("Linha 2 - a não é menor que b");
      }
      
      if (a > b) {
         Console.WriteLine("Linha 3 - a é maior que b");
      } else {
         Console.WriteLine("Linha 3 - a não é maior que b");
      }
      
      /* Alterando os valores de a e b */
      a = 5;
      b = 20;
      
      if (a <= b) { 
         Console.WriteLine("Linha 4 - a é menor ou igual a b");
      }
      
      if (b >= a) {
         Console.WriteLine("Linha 5 - b é maior ou igual a a");
      }
   }
}
