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
		protected int largura;
		protected int altura;
	}
	public interface CustoPintura
	{	
		int getCusto(int area);		
	}
	public class Retangulo:Forma,CustoPintura
	{
		public int getArea()
		{
			return largura*altura;
		}
		public int getCusto(int area)
		{
			return area*70;
		}
	}
	public class RetanguloTester
	{
		static void Main(string[] args)
		{
			Retangulo ret=new Retangulo();
			int area;

			ret.setLargura(5);
			ret.setAltura(7);
			area=ret.getArea();

			Console.WriteLine("Área total: {0}",ret.getArea());
			Console.WriteLine("Custo total de pintura: ${0}",ret.getCusto(area));
			Console.ReadKey();
		}
	}
}
