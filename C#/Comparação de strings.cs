using System;

namespace AplicacaoString{
   class StringProg {
      static void Main(string[] args) {
         string str1 = "This is test";
         string str2 = "This is text";

		/* O método 'Compare' testará se duas strings são iguais,
			ou não. Caso sejam iguais, ele retorna 0, caso contrário,
			elas não são iguais.
		*/
         if (String.Compare(str1, str2) == 0) {
            Console.WriteLine(str1 + " e " + str2 +  " são iguais.");
         } else {
            Console.WriteLine(str1 + " e " + str2 + " não são iguais.");
         }
         Console.ReadKey() ;
      }
   }
}