using System;

namespace AplicacaoCalculadora {
   class NumberManipulator {
	/* Aqui a passagem de parâmetros está sendo por referência,
	   ou seja, está sendo passado não o valor, e sim, a própria variável, 
	   digamos assim.
	*/
      public void troca(ref int x, ref int y) {
         int temp;

         temp = x;
         x = y;
         y = temp;
      }
      static void Main(string[] args) {
         NumberManipulator n = new NumberManipulator();
         
         int a = 100;
         int b = 200;

         Console.WriteLine("Antes da troca o valor de a era: {0}", a);
         Console.WriteLine("Antes da troca o valor de b era: {0}", b);

         n.troca(ref a, ref b);

         Console.WriteLine("Depois da troca o valor de a é: {0}", a);
         Console.WriteLine("Depois da troca o valor de b é: {0}", b);
 
         Console.ReadLine();
      }
   }
}