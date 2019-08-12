using System;

namespace AplicacaoVarEstatica{
	class VarEstatica{
		public static int num;
		
		public void contar(){
			num++;
		}

		public static int getNum(){
			return num;
			/* Os métodos estáticos só podem acessar membros estáticos
			 * da classe. Por causa disso, a variável 'num', neste caso,
			 * também está sendo estática.
			 */
		}
	}

	class StaticTester{
		static void Main(string[] args){
			VarEstatica v=new VarEstatica();

			v.contar();
			v.contar();
			v.contar();

			Console.WriteLine("Variável num: {0}",VarEstatica.getNum());
			Console.ReadKey();
		}
	}
}
