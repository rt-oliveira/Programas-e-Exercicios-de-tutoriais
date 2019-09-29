using System;
using System.IO;

namespace AplicacaoArquivo{
	class Programa{
		static void Main(string[] args){
			try
			{
				using (StreamReader sr=new StreamReader("Jamaica.txt")){
					string linha;

					while ((linha=sr.ReadLine())!=null)	
					{
						Console.WriteLine(linha);
					}
				}
			}
			catch (Exception e)
			{
				Console.WriteLine("O arquivo não pôde ser lido");
				Console.WriteLine(e.Message);
			}
			Console.ReadKey();
		}
	}
}
