using System;

namespace AplicacaoVarEstatica{
	class VarEstatica{
		public static int num;

		public void contar(){
			num++;
		}
		public int getNum(){
			return num;
		}
	}

	class StaticTester{
		static void Main(string[] args){
			VarEstatica v1=new VarEstatica();
			VarEstatica v2=new VarEstatica();

			v1.contar();
			v1.contar();
			v1.contar();

			v2.contar();
			v2.contar();
			v2.contar();

			Console.WriteLine("Variável num em v1: {0}",v1.getNum());
			Console.WriteLine("Variável num em v2: {0}",v2.getNum());
			Console.ReadKey();
		}
	}
}
