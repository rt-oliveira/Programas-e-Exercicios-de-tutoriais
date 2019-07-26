using System;

namespace DefinicaoVariavel{
	class Programa{
		static void Main(string[] args){

			/* 3 variáveis, de tipos diferentes.
				Isso mostra como são definidas as variáveis em C#.*/
			short a;
			int b;
			double c;

			a=10;
			b=20;
			c=a+b;
			Console.WriteLine("a={0}, b={1}, c={2}",a,b,c);
			Console.ReadLine();
		}
	}
}