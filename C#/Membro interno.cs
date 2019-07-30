using System;

namespace AplicacaoRetangulo {
   class Retangulo {
      internal double largura;
      internal double altura;
      
      double GetArea() {
         return largura * altura;
      }
      public void Display() {
         Console.WriteLine("Largura: {0}", largura);
         Console.WriteLine("Altura: {0}", altura);
         Console.WriteLine("Área: {0}", GetArea());
      }
   }
   
   class ExecuteRetangulo {
      static void Main(string[] args) {
         Retangulo r = new Retangulo();
         /* Como são membros marcados como 'internal' podem ser acessados dentro
         	do namespace definido, em qualquer método/classe.
         */
         r.largura = 4.5;
         r.altura = 3.5;
         r.Display();
         Console.ReadLine();
      }
   }
}