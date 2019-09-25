using System;
using System.Text.RegularExpressions;

namespace AplicacaoRegEx{
	class Programa
	{
		private static void mostrarMatch(string texto,string expr){
			Console.WriteLine("A expressão: "+expr);
			MatchCollection mc=Regex.Matches(texto,expr);

			foreach(Match m in mc){
				Console.WriteLine(m);
			}
		}
		static void Main(string[] args)
		{
			string str="A Thousand Splendid Suns";

			Console.WriteLine("Ocorrências de palavras que começam com S");
			mostrarMatch(str,@"\bS\S*");
			Console.ReadKey();
		}
	}
}
