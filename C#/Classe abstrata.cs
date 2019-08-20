using System;

namespace AplicacaoPolimorfismo
{
	abstract class Forma
	{
		public abstract int area();
	}
	class Retangulo: Forma
	{
		private int comprimento;
		private int largura;

		public Retangulo(int a=0,int b=0){
			comprimento=a;
			largura=b;
		}

		// O modificador 'override' indica que está sobrescrevendo algo vindo de outra classe.
		// Nesse caso está implementando um método abstrato.
		public override int area(){
			Console.WriteLine("Área da classe Retangulo: ");
			return (comprimento*largura);
		}
	}
	public class RetanguloTester
	{
		static void Main(string[] args)
		{
			Retangulo r=new Retangulo(10,7);
			double a=r.area();
			Console.WriteLine("Area: {0}",a);
			Console.ReadKey();
		}
	}
}
