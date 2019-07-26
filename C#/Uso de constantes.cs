using System;

namespace DeclaracaoDeConstantes{
	class Program{
		static void Main(string[] args){
			// Declaração de uma constante
			const double pi=3.14159;

			double r;
			Console.WriteLine("Digite o valor do raio: ");
			r=Convert.ToDouble(Console.ReadLine());

			double areaCirculo=pi*r*r;
			Console.WriteLine("Raio: {0}, Área: {1}",r,areaCirculo);
			Console.ReadLine();
		}
	}
}