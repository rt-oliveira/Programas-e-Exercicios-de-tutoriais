using System;

namespace AplicacaoCaixa{
	class Caixa{
		public double comprimento;
		public double profundidade;
		public double altura;
		// Definição dos atributos da classe Caixa
	}
	class TesteCaixa{
		static void Main(string[] args){
			Caixa Caixa1=new Caixa();
			Caixa Caixa2=new Caixa();
			// Declarados 2 variáveis do tipo Caixa

			double volume=0;

			// Especificação da Caixa1
			Caixa1.altura=5;
			Caixa1.comprimento=6;
			Caixa1.profundidade=7;

			// Especificação da Caixa2
			Caixa2.altura=10;
			Caixa2.comprimento=12;
			Caixa2.profundidade=13;

			// Cálculo do volume de caixa1
			volume = Caixa1.altura*Caixa1.comprimento*Caixa1.profundidade;
			Console.WriteLine("Volume de Caixa1: {0}",volume);

			// Cálculo do volume de caixa2
			volume = Caixa2.altura*Caixa2.comprimento*Caixa2.profundidade;
			Console.WriteLine("Volume de Caixa2: {0}",volume);

			Console.ReadKey();
		}
	}
}
