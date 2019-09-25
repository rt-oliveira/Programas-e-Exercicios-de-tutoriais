using	System;

namespace ExcecaoDefinidaUsuario{
	class TesteTemperatura
	{
			static void Main(string[] args)
			{
				Temperatura temp=new Temperatura();
				try{
					temp.mostrarTemperatura();
				} catch(ExcecaoTemperaturaEhZero e){
					Console.WriteLine("ExcecaoTemperaturaEhZero: {0}", e.Message);
				}
				Console.ReadKey();
			}
	}
}
public class ExcecaoTemperaturaEhZero: Exception{
	public ExcecaoTemperaturaEhZero(string message):base(message){
	}
}
public class Temperatura
{
	int temperatura=0;

	public void	mostrarTemperatura(){
		if(temperatura==0)
			throw (new ExcecaoTemperaturaEhZero("Encontrada temperatura zero"));
		else
			Console.WriteLine("Temperatura: {0}",temperatura);
	}
}
