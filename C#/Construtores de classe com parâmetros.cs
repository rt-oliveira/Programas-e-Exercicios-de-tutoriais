using System;

namespace AplicacaoLinha{
	class Linha{
		private double comprimento;

		public Linha(double comp){ // Este é um método construtor com parâmetros
			Console.WriteLine("Objeto está sendo criado, comprimento = {0}", comp);
			comprimento=comp;
		}
		public void setComprimento(double comp){
			comprimento=comp;
		}
		public double getComprimento(){
			return comprimento;
		}

		static void Main(string[] args){
			Linha linha=new Linha(10);
			Console.WriteLine("Comprimento da linha: {0}",linha.getComprimento());

			linha.setComprimento(6);
			Console.WriteLine("Comprimento da linha: {0}",linha.getComprimento());

			Console.ReadKey();
		}
	}
}
