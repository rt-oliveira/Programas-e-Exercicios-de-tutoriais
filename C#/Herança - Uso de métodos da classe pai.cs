using System;

namespace AplicacaoRetangulo
{
	public class Retangulo
	{
		protected double comprimento;
		protected double largura;

		public Retangulo(double c, double l){
			comprimento=c;
			largura=l;
		}

		public double GetArea(){
			return comprimento*largura;
		}
		public void Mostrar(){
			Console.WriteLine("Comprimento: {0}",comprimento);
			Console.WriteLine("Largura: {0}",largura);
			Console.WriteLine("Área: {0}",GetArea());
		}
	}
	public class Mesa: Retangulo // Aqui está sendo feita uma herança, onde a clase Mesa herda os atributos e métodos da classe Retangulo
	{
		private double custo;
		public Mesa(double c,double l): base(c,l){} /* Esse comando tem o objetivo de instanciar uma nova Mesa. Porém, para tal ele invoca o
																									 método construtor da classe pai.*/

		public double GetCusto(){
			double custo;
			custo=GetArea()*70;
			return custo;
		}
		public void Mostrar(){
			base.Mostrar(); // Aqui há a invocação de um método de mesmo de nome, mas da classe pai.
			Console.WriteLine("Custo: {0}",GetCusto());
		}
	}
	public class ExecuteRetangulo
	{
		static void Main(string[] args)
		{
			Mesa m=new Mesa(4.5,7.5);
			m.Mostrar();
			Console.ReadLine();
		}
	}
}
