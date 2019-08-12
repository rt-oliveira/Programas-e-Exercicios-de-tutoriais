using System;

namespace AplicacaoLinha{
	class Linha{
		private double comprimento;

		public Linha(){
			Console.WriteLine("Objeto sendo criado");
		}
		public void setComprimento(double comp){
			comprimento=comp;
		}
		public double getComprimento(){
			return comprimento;
		}
		static void Main(string[] args){
			Linha linha=new Linha(); // Está instanciando um objeto do tipo linha.

			linha.setComprimento(6);
			Console.WriteLine("Comprimento da linha: {0}",linha.getComprimento());
			Console.ReadKey();
		}
	}
}
