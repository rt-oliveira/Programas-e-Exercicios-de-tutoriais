using System;

namespace AplicacaoStringStringApplication {
   class StringProg {
      static void Main(string[] args) {
         string str = "Last night I dreamt of San Pedro";
         Console.WriteLine(str);
		 /* Este m�todo 'Substring' retornar� uma string,
			que ter� como origem a string usada para o m�todo, 
			a partir da posi��o dada como par�metro.
			
			Neste exemplo, ser� retornado uma string, que tem como
			origem a vari�vel 'str', e que come�a a partir da posi��o 23.
		 */
         string substr = str.Substring(23);
         Console.WriteLine(substr);
      }
   }
}