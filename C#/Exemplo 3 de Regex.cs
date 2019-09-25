using System;
using System.Text.RegularExpressions;

namespace AplicacaoRegEx
{
	class Programa
	{
		static void Main(string[] args)
		{
			string input="Hello   World   ";
			string padrao="\\s+";
			string substituicao=" ";

			Regex rgx=new Regex(padrao);
			string resultado=rgx.Replace(input,substituicao);

			Console.WriteLine("String original: {0}",input);
			Console.WriteLine("String com substituição: {0}",resultado);
			Console.ReadKey();
		}
	}
}

