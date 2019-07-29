using System;

namespace TomadaDecisao {
   class Program {
      static void Main(string[] args) {
         char grau = 'B';
         
		 // Um exemplo do switch..case.
         switch (grau) {
            case 'A':
               Console.WriteLine("Excelente!");
               break;
            case 'B':
            case 'C':
               Console.WriteLine("Muito bem");
               break;
            case 'D':
               Console.WriteLine("Você passou");
               break;
            case 'F':
               Console.WriteLine("Melhor tentar novamente");
               break;
               default:
            Console.WriteLine("Grau inválido");
               break;
         }
         Console.WriteLine("Seu grau é {0}", grade);
         Console.ReadLine();
      }
   }
}
