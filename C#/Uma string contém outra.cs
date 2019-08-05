using System;

namespace AplicacaoString{
   class StringProg {
      static void Main(string[] args) {
         string str = "This is test";
         
		 /* O método 'Contains' testa se uma determinada string
			está contida em outra.
		 */
         if (str.Contains("test")) {
            Console.WriteLine("A sequência 'test' foi encontrada.");
         }
         Console.ReadKey() ;
      }
   }
}