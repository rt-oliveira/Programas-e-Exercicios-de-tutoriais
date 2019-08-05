using System;

namespace AplicacaoString{
   class StringProg {
      static void Main(string[] args) {
		// Este � um vetor de strings.
        string[] vetor_strings = new string[]{"Down the way nights are dark",
            "And the sun shines daily on the mountain top",
            "I took a trip on a sailing ship",
            "And when I reached Jamaica",
            "I made a stop"};

		/* O m�todo 'Join' da classe String unir� as strings do vetor
			dado como segundo par�metro, sendo que entre cada uma delas 
			haver� um caractere daquele dado como primeiro par�metro.
		*/
         string str = String.Join("\n",vetor_strings);
         Console.WriteLine(str);
      }
   }
}