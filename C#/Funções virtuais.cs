using System;

namespace AplicacaoPolimorfismo
{
	class Forma
	{
		protected int largura,altura;

		public Forma(int a=0,int b=0){
			largura=a;
			altura=b;
		}

		// Esta é uma função virtual. Ela "obriga" as classes filhas a terem que
		// reimplementá-la.
		public virtual int area(){ 
			Console.WriteLine("Área da classe pai: ");
			return 0;
		}
	}
	class Retangulo: Forma{
		public Retangulo(int a=0,int b=0): base (a,b){}

		public override int area(){
			Console.WriteLine("Área da classe Retangulo: ");
			return largura*altura;
		}
	}
	class Triangulo: Forma{
		public Triangulo (int a=0,int b=0): base (a,b){}

		public override int area(){
			Console.WriteLine("Área da classe Triangulo: ");
			return (largura*altura/2);
		}
	}
	class Chamador{
		public void ChamarArea(Forma f){
			int a;
			a=f.area();
			Console.WriteLine("Área: {0}",a);
		}
	}
	class Tester{
		static void Main(string[] args)
		{
			Chamador c=new Chamador();	
			Retangulo r=new Retangulo(10,7);
			Triangulo t=new Triangulo(10,5);

			c.ChamarArea(r); // Aqui será executada a função area de Retangulo
			c.ChamarArea(t); // Aqui será executada a função area de Triangulo
			Console.ReadKey();
		}
	}
}
