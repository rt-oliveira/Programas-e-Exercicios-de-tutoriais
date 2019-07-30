using System;

namespace AplicacaoRetangulo{
   class Retangulo {
      private double largura;
      private double altura;
      
      // Aqui dentro da classe os atributos podem ser acessados normalmente.
      public void AceitarDetalhes() {
         Console.WriteLine("Digite a largura: ");
         largura = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("Digite a altura: ");
         altura = Convert.ToDouble(Console.ReadLine());
      }
      public double GetArea() {
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
         /* Como 'largura' e 'altura' são membros privados da classe Retangulo
            eles não podem ser acessados aqui. Algum método da classe é quem tem
            que acessá-los para recuperar/configurar o valor.
         */
         r.AceitarDetalhes();
         r.Display();
         Console.ReadLine();
      }
   }
}