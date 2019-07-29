using System;

namespace TomadaDecisao {
   class Program {
      static void Main(string[] args) {
         int a = 100;
         
		 // Testa condição
         if (a == 10) {
            // Se a=10, entra aqui.
            Console.WriteLine("O valor de a é 10");
         } 
         else if (a == 20) {
            // Entra aqui se a não for 10, mas tiver valor 20.
            Console.WriteLine("O valor de a é 20");
         } 
         else if (a == 30) {
            // Entra aqui caso a não tenha 10, nem 20, mas tenha valor 30.
            Console.WriteLine("O valor de a é 30");
         } else {
			// Entra aqui caso nenhuma das condições anteriores seja verdadeira.
            Console.WriteLine("Corresponde a nenhum dos valores");
         }
         Console.WriteLine("O valor exato de a é {0}", a);
         Console.ReadLine();
      }
   }
}
