using System;

namespace AplicacaoCalculadora {
   class MostrandoNullaveis {
      static void Main(string[] args) {
         int? num1 = null;
         int? num2 = 45;
         double? num3 = new double?(); // Nesse caso, com o new <tipo>?, o valor default será 'null'.
         double? num4 = 3.14157;
	/*Estas 4 variáveis acima são do tipo Nullable<tipo>.
	  Isto representa o mesmo tipo de dado definido acima, com a adição
	  da possibilidade de atribuir o valor 'null' a eles.
	*/
         
         bool? boolval = new bool?(); // Isso acontece também aqui.

	 // Mostrando os Nullables
         Console.WriteLine("Mostrando Nullables: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
         Console.WriteLine("Um valor boolean Nullable: {0}", boolval);
         Console.ReadLine();
      }
   }
}