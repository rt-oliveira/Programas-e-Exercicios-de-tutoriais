using System;

namespace AplicacaoString{
   class StringProg {
      static void Main(string[] args) {
		// Este é um vetor de strings.
        string[] vetor_strings = new string[]{"Down the way nights are dark",
            "And the sun shines daily on the mountain top",
            "I took a trip on a sailing ship",
            "And when I reached Jamaica",
            "I made a stop"};

		/* O método 'Join' da classe String unirá as strings do vetor
			dado como segundo parâmetro, sendo que entre cada uma delas 
			haverá um caractere daquele dado como primeiro parâmetro.
		*/
         string str = String.Join("\n",vetor_strings);
         Console.WriteLine(str);
      }
   }
}