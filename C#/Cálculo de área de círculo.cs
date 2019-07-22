//Exercício do site https://docs.microsoft.com/pt-br/dotnet/csharp/tutorials/intro-to-csharp/numbers-in-csharp?tutorial-step=5

using System;

namespace Estudo{
	class ClasseEstudo{
		static void Main(string[] args){
			double raio=2.5;
			double area=raio*raio*Math.PI;
			Console.WriteLine($"{area}");
		}
	}
}
