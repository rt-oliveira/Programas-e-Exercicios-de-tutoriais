using System;

namespace CalculatorApplication {
   class NumberManipulator {
	/*Aqui está havendo uma passagem de parâmetro que vai ser usado como
	  parâmetro de saída de um método. Isso entra em casos em que precisa retornar mais itens
	  do que apenas um elemento de algum tipo.
	*/
      public void getValor(out int x ) {
         int temp = 5;
         x = temp;
      }
      static void Main(string[] args) {
         NumberManipulator n = new NumberManipulator();
         int a = 100;
         
         Console.WriteLine("Antes da chamada do método o valor de a era: {0}", a);
         n.getValor(out a);
         Console.WriteLine("Depois da chamada do método o valor de a é: {0}", a);
         Console.ReadLine();
      }
   }
}