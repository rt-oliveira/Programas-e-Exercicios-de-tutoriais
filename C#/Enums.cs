using System;

namespace AplicacaoEnums{
	class ProgramaEnum{
		// Uma enumeração está sendo criada.
		enum DiasDaSemana { Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado};
		static void Main(string[] args){
			// Aqui está sendo feito referência a dois elementos do enum.
			int DiaDeSemanaInicio= (int)DiasDaSemana.Segunda;
			int DiaDeSemanaFim= (int)DiasDaSemana.Sexta;
			
			Console.WriteLine("Segunda: {0}",DiaDeSemanaInicio);
			Console.WriteLine("Sexta: {0}",DiaDeSemanaFim);
			Console.ReadKey();
		}
	}
}