using System;

namespace AplicacaoOperadores {
   class Program {
      static void Main(string[] args) {
         int a = 60;
         int b = 13;
         int c = 0; 
         
		 // Isto significa que será feito um E bit-a-bit.
         c = a & b;
         Console.WriteLine("Linha 1 - Valor de c é {0}", c );
         
		 // Isto significa que será feito um OU bit-a-bit.
         c = a | b;
         Console.WriteLine("Linha 2 - Valor de c é {0}", c);
         
		 // Isto significa que será feito um XOR bit-a-bit.
         c = a ^ b;
         Console.WriteLine("Linha 3 - Valor de c é {0}", c);
         
		 /* Isto significa que será feito uma negação de um número.
		 	A negação de um número, nesse caso, é o complemento a 2 do mesmo.
		 */
         c = ~a;              
         Console.WriteLine("Linha 4 - Valor de c é {0}", c);
         
		 /* Isto significa que será feito um 'shift' à esquerda.
		  * Isto é, os bits que representam aquele número serão
		  * movimentados 2 espaços para a esquerda.
		  * 
		  * Movimentar todos os bits de um número 1 posição para a 
		  * esquerda provoca como resultado o dobro do número inicial.
		  */
         c = a << 2;
         Console.WriteLine("Linha 5 - Valor de c é {0}", c);
         
		 /* Isto significa que será feito um 'shift' à direita.
		  * Isto é, os bits que representam aquele número serão
		  * movimentados 2 espaços para a direita.
		  *
		  * Movimentar todos os bits de um número 1 posição para a 
		  * direita provoca como resultado a metade do número inicial.
		  */
         c = a >> 2;
         Console.WriteLine("Linha 6 - Valor de c é {0}", c);
         Console.ReadLine();
      }
   }
}
