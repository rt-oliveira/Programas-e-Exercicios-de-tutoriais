using System;

namespace AplicacaoConversaoTipo{
	class ConversaoExplicita{
		static void Main(string[] args){
			double d=5673.74;
			int i;

			// Conversão explícita sendo feita, de um valor double para int.
			i=(int)d;
			// Com essa conversão, a parte decimal do número double é perdida.
			Console.WriteLine(i);
			Console.ReadKey();
		}
	}
}