using System;

namespace AplicacaoVetor {
   class VetorParam {
      /* Esse 'params' indica que terá uma quantidade indeterminada de argumentos,
         e, neste caso, todos eles tem que ser inteiros. */	
      public int SomaElementos(params int[] vet) {
         int soma = 0;
         
         foreach (int i in vet) {
            soma += i;
         }
         return soma;
      }
   }
   class ClasseTeste {
      static void Main(string[] args) {
         VetorParam app = new VetorParam();
         int soma = app.SomaElementos(512, 720, 250, 567, 889);
         
         Console.WriteLine("O valor da soma: {0}", soma);
         Console.ReadKey();
      }
   }
}