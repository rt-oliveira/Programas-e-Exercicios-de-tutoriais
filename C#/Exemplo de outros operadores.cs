using System;

namespace AplicacaoOperadores {
   class Program {
      static void Main(string[] args) {
         /* Exemplos do operador sizeof.
		  * Este operador mostra o tamanho de um determinado elemento ou tipo de dado.
		  */
         Console.WriteLine("O tamanho do int é {0}", sizeof(int));
         Console.WriteLine("O tamanho do short é {0}", sizeof(short));
         Console.WriteLine("O tamanho do double é {0}", sizeof(double));
         
         /* Exemplos do operador ternário.
		  * O operador ternário serve para fazer comparações imediatas.
		  * Serve para testar expressões.
		  */
         int a, b;
         a = 10;
         b = (a == 1) ? 20 : 30;
         Console.WriteLine("O valor de b é {0}", b);

         b = (a == 10) ? 20 : 30;
         Console.WriteLine("O valor de b é {0}", b);
         Console.ReadLine();
      }
   }
}
