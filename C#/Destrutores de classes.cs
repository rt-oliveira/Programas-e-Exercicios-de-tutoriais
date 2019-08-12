using System;

namespace AplicacaoLinha{
	class Linha{
		private double comprimento;

		public Linha(){
			Console.WriteLine("O objeto está sendo criado.");
		}

		~Linha(){	// Método destrutor
			Console.WriteLine("O objeto está sendo destruído.");
		}

		public void setComprimento(double comp){
			comprimento=comp;
		}
		public double getComprimento(){
			return comprimento;
		}
		static void Main(string[] args){
			Linha linha=new Linha();

			linha.setComprimento(6);
			Console.WriteLine("Comprimento da linha: {0}",linha.getComprimento());
		}
	}
}
