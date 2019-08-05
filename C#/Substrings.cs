using System;

namespace AplicacaoStringStringApplication {
   class StringProg {
      static void Main(string[] args) {
         string str = "Last night I dreamt of San Pedro";
         Console.WriteLine(str);
		 /* Este método 'Substring' retornará uma string,
			que terá como origem a string usada para o método, 
			a partir da posição dada como parâmetro.
			
			Neste exemplo, será retornado uma string, que tem como
			origem a variável 'str', e que começa a partir da posição 23.
		 */
         string substr = str.Substring(23);
         Console.WriteLine(substr);
      }
   }
}