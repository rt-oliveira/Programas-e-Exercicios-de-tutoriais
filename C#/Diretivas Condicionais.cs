#define DEBUG
#define VC_V10
using System;

public class ClassTeste{
	public static void Main(){
		#if(DEBUG && !VC_V10)
			Console.WriteLine("DEBUG est� definido");
		#elif (!DEBUG && VC_V10)
			Console.WriteLine("VC_V10 est� definido");
		#elif (DEBUG && VC_V10)
			Console.WriteLine("DEBUG e VC_V10 est�o definidos");
		#else
			Console.WriteLine("Nem DEBUG, nem VC_V10 est�o definidos");
		#endif
		Console.ReadKey();
	}
}
