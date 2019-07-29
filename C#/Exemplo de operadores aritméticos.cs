using System;

namespace AplicacaoOperadores{
	class Programa{
		static void Main(string[] args){
			int a=21;
			int b=10;
			int c;

			c=a+b;
			Console.WriteLine("Linha 1 - Valor de c é {0}",c);

			c=a-b;
			Console.WriteLine("Linha 2 - Valor de c é {0}",c);

			c=a*b;
			Console.WriteLine("Linha 3 - Valor de c é {0}",c);

			c=a/b;
			Console.WriteLine("Linha 4 - Valor de c é {0}",c);

			// Esta é a operação de resto de divisão.
			c=a%b;
			Console.WriteLine("Linha 5 - Valor de c é {0}",c);

			// Isto significa o incremento de um valor em uma unidade.
			c=a++;
			Console.WriteLine("Linha 6 - Valor de c é {0}",c);

			// Isto significa o decremento de um valor em uma unidade.
			c=a--;
			Console.WriteLine("Linha 7 - Valor de c é {0}",c);
			Console.ReadLine();
		}
	}
}


