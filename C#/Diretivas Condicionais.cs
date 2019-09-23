#define DEBUG
#define VC_V10
using System;

public class ClassTeste{
	public static void Main(){
		#if(DEBUG && !VC_V10)
			Console.WriteLine("DEBUG está definido");
		#elif (!DEBUG && VC_V10)
			Console.WriteLine("VC_V10 está definido");
		#elif (DEBUG && VC_V10)
			Console.WriteLine("DEBUG e VC_V10 estão definidos");
		#else
			Console.WriteLine("Nem DEBUG, nem VC_V10 estão definidos");
		#endif
		Console.ReadKey();
	}
}
