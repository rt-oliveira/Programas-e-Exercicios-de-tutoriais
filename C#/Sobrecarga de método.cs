using System;

namespace AplicacaoPolimorfismo
{
	class ImprimirDados
	{
		void imprimir(int i)
		{
			Console.WriteLine("Imprimindo int: {0}",i);
		}
		void imprimir(double f)
		{
			Console.WriteLine("Imprimindo float: {0}",f);
		}
		void imprimir(string s)
		{
			Console.WriteLine("Imprimindo string: {0}",s);
		}
		public static void Main(string[] args)
		{
			ImprimirDados	i=new ImprimirDados();

			i.imprimir(5); // Chamada para imprimir inteiro
			i.imprimir(500.263); // Chamada para imprimir float
			i.imprimir("Olá C#"); // Chamada para imprimir string
			Console.ReadKey();
		}
	}
}
