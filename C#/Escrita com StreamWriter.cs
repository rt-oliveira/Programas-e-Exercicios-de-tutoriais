using System;
using System.IO;

namespace AplicacaoArquivo{
	class Programa{
		static void Main(string[] args){
			string[] nomes=new string[]{"Zara Ali","Nuha Ali"};

			using(StreamWriter sw=new StreamWriter("nomes.txt")){
				foreach (string s in nomes)
				{
					sw.WriteLine(s);
				}
			}

			string linha="";
			using(StreamReader sr=new StreamReader("nomes.txt")){
				while ((linha=sr.ReadLine())!=null)
				{
					Console.WriteLine(linha);
				}
			}
				Console.ReadKey();
		}
	}
}
