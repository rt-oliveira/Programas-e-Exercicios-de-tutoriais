using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;

namespace AplicacaoInterface{
	public interface ITransacoes{
		void mostrarTransacao();
		double getQuantia();
	}
	public class Transacao:ITransacoes{
		private string tCodigo;
		private string data;
		private double quantia;

		public Transacao(){
			tCodigo=" ";
			data=" ";
			quantia=0;
		}
		public Transacao(string c,string d,double q){
			tCodigo=c;
			data=d;
			quantia=q;
		}
		public double getQuantia(){
			return quantia;
		}
		public void mostrarTransacao(){
			Console.WriteLine("Transação: {0}",tCodigo);
			Console.WriteLine("Data: {0}",data);
			Console.WriteLine("Quantia: {0}", quantia);
		}
	}
	class Tester{
		static void Main(string[] args)
		{
			Transacao t1=new Transacao("001","8/10/2012",78900);
			Transacao t2=new Transacao("002","9/10/2012",451900);

			t1.mostrarTransacao();
			t2.mostrarTransacao();
			Console.ReadKey();
		}
	}
}
