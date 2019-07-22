// Exercício do site https://docs.microsoft.com/pt-br/dotnet/csharp/tutorials/intro-to-csharp/list-collection?tutorial-step=5

using System;
using System.Collections.Generic;

namespace Estudo{
	class ClasseEstudo{
		static void Main(string[] args){
			var fibonacciNumbers = new List<int> {1, 1};

			for(int i=0;i<18;i++){
				var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
				var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
				fibonacciNumbers.Add(previous + previous2);
			}
			foreach(var item in fibonacciNumbers)
				Console.WriteLine(item);
		}
	}
}
