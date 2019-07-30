using System;

namespace CalculatorApplication {
   class MostrarNullables {
      static void Main(string[] args) {
         double? num1 = null;
         double? num2 = 3.14157;
         double num3;
         
	 /* Este é o operador de coalescência de nullable.
	    Isto possibilita converter um operando de um tipo para o seu tipo Nullable.
	    Isto funciona da seguinte maneira:
	    
	    Supondo c = a ?? b:
	    - Caso a seja 'null', c recebe b. 
	    - Caso contrário, c recebe a.
	 */
         num3 = num1 ?? 5.34;      
         Console.WriteLine("Valor de num3: {0}", num3);
         
         num3 = num2 ?? 5.34;
         Console.WriteLine("Valor de num3: {0}", num3);
         Console.ReadLine();
      }
   }
}