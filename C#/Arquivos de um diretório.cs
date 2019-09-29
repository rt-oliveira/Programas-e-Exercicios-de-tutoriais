using System;
using System.IO;

namespace AplicacaoArquivoWindows{
	class Programa{
		static void Main(string[] args){
			// criando objeto DirectoryIndo
			DirectoryInfo meudir=new DirectoryInfo(@"c:\Windows");

			// recuperando os arquivos do diretório, seus nomes e tamanhos
			FileInfo[] f=meudir.GetFiles();
			foreach (FileInfo arq in f)
			{
				Console.WriteLine("Nome do arquivo: {0} Tamanho: {1}",arq.Name,arq.Length);
			}

			Console.ReadKey();
		}
	}
}
