using System;

namespace AplicacaoString{
   class StringProg {
      static void Main(string[] args) {
         string str = "This is test";
         
		 /* O m�todo 'Contains' testa se uma determinada string
			est� contida em outra.
		 */
         if (str.Contains("test")) {
            Console.WriteLine("A sequ�ncia 'test' foi encontrada.");
         }
         Console.ReadKey() ;
      }
   }
}