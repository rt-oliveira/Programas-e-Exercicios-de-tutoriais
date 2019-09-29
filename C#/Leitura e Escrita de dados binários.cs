using System;
using System.IO;

namespace AplicacaoArquivoBinario{
	class Programa{
		static void Main(string[] args){
			BinaryWriter bw;
			BinaryReader br;

			int i=25;
			double d=3.14157;
			bool b=true;
			string s="I am happy";

			// criação do arquivo
			try
			{
				bw=new BinaryWriter(new FileStream("meus dados",FileMode.Create));
			}
			catch (IOException e)
			{
				Console.WriteLine(e.Message+"\n Não foi possível criar arquivo.");
				return;
			}

			// escrita no arquivo
			try
			{
				bw.Write(i);
				bw.Write(d);
				bw.Write(b);
				bw.Write(s);	
			}
			catch (IOException e)
			{
				Console.WriteLine(e.Message+"\n Não foi possível escrever no arquivo.");
			}
			bw.Close();

			// leitura do arquivo criado
			try
			{
				br=new BinaryReader(new FileStream("meus dados",FileMode.Open));
			}
			catch (IOException e)
			{
				Console.WriteLine(e.Message+"\n Não foi possível abrir o arquivo.");
				return;
			}

			try
			{
				i=br.ReadInt32();
				Console.WriteLine("Dados inteiros: {0}",i);
				d=br.ReadDouble();
				Console.WriteLine("Dados double: {0}",d);
				b=br.ReadBoolean();
				Console.WriteLine("Dados booleanos: {0}",b);
				s=br.ReadString();
				Console.WriteLine("Dados string: {0}",s);
			}
			catch (IOException e)
			{
				Console.WriteLine(e.Message+"\n Não foi possível ler o arquivo.");
				return;
			}
			
			br.Close();
			Console.ReadKey();
		}
	}
}
