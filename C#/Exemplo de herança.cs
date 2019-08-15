using System;

namespace AplicacaoHeranca
{
	public class Forma
	{
		public void setLargura(int l){
			largura=l;
		}
		public void setAltura(int a){
			altura=a;
		}
		protected	int largura;
		protected int altura;
	}
	// Classe filha/derivada
	public class Retangulo: Forma
	{
		public int getArea(){
			return (altura*largura);
		}
	}
	public class TesteRetangulo
	{
		static void Main(string[] args)
		{
			Retangulo ret=new Retangulo();

			ret.setLargura(5);
			ret.setAltura(7);

			// Imprimindo a área do objeto
			Console.WriteLine("Total area: {0}",ret.getArea());
			Console.ReadKey();
		}		
	}
}
