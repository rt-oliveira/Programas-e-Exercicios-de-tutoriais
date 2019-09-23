#define PI
using System;

namespace AplicacaoPreProcessador
{
	class Programa
	{
		static void Main(string[] args)
		{
			#if(PI)
				Console.WriteLine("PI está definido");
			#else
				Console.WriteLine("PI não está definido");
			#endif
			Console.ReadKey();
		}
	}
}
