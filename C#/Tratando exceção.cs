using System;

namespace AplicacaoTratamentoExcecao
{
	public class DivNumbers
	{
		int resultado;

		DivNumbers(){
			resultado=0;
		}
		public void divisao(int num1,int num2){
			try{
				resultado=num1/num2;
			} catch(DivideByZeroException e){
				Console.WriteLine("Exceção ocorrida: {0}",e);
			} finally{
				Console.WriteLine("Resultado: {0}",resultado);
			}
		}
		static void Main(string[] args)
		{
			DivNumbers d=new DivNumbers();
			d.divisao(25,0);
			Console.ReadKey();
		}
	}
}
