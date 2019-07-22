// Exercício do site https://docs.microsoft.com/pt-br/dotnet/csharp/tutorials/intro-to-csharp/branches-and-loops?tutorial-step=5
using System;

namespace Estudo{
	class ClasseEstudo{
		static void Main(string[] args){
			int soma=0;
			for(int i=1;i<=20;i++){
				if(i%3==0)
					soma+=i;
			}
			Console.WriteLine(soma);
		}
	}
}
