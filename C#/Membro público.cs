using System;

namespace AplicacaoRetangulo {
   class Retangulo {
   	// As variáveis.
      public double largura;
      public double altura;
      
      public double GetArea() {
         return largura * altura;
      }
      public void Display() {
         Console.WriteLine("Base: {0}", largura);
         Console.WriteLine("Altura: {0}", altura);
         Console.WriteLine("Área: {0}", GetArea());
      }
   }   
   class ExecutarRetangulo {
      static void Main(string[] args) {
         Retangulo r = new Retangulo();
         /* Como 'largura' e 'altura' são públicos, eles podem ser acessados de qualquer lugar,
         	fora ou dentro da classe onde foi declarado.
         */
         r.largura = 4.5;
         r.altura = 3.5;
         r.Display();
         Console.ReadLine();
      }
   }
}