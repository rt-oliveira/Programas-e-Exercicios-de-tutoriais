using System;

namespace AplicacaoCaixa{
	class Caixa{
		private double comprimento;
		private double profundidade;
		private double altura;

		public void setComprimento(double comp){
			comprimento=comp;
		}

		public void setProfundidade(double prof){
			profundidade=prof;
		}

		public void setAltura(double alt){
			altura=alt;
		}

		public double getVolume(){
			return comprimento*profundidade*altura;
		}
	}
	class TesteCaixa{
		static void Main(string[] args){
			Caixa Caixa1=new Caixa();
			Caixa Caixa2=new Caixa();	// 2 variáveis do tipo Caixa declaradas
			double volume;

			Caixa1.setComprimento(6);
			Caixa1.setProfundidade(7);
			Caixa1.setAltura(5);

			Caixa2.setComprimento(12);
			Caixa2.setProfundidade(13);
			Caixa2.setAltura(10);				// Foram especificadas Caixa1 e Caixa2

			volume=Caixa1.getVolume();
			Console.WriteLine("Volume de Caixa1 : {0}" ,volume);
         
      volume=Caixa2.getVolume();
      Console.WriteLine("Volume de Caixa2 : {0}", volume);
			// Volume das 2 caixas
         
      Console.ReadKey();
		}
	}
}
