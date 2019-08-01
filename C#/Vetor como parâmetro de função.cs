using System;

namespace AplicacaoVetor {
   class MeuVetor {
      double getMedia(int[] vet, int tam) {
         int i;
         double media;
         int soma = 0;
         
         for (i = 0; i < tam; ++i) {
            soma += vet[i];
         }
         media = (double)soma / tam;
         return media;
      }
      static void Main(string[] args) {
         MeuVetor app = new MeuVetor();
         
         int [] balance = new int[]{1000, 2, 3, 17, 50};
         double media;

         media = app.getMedia(balance, 5 ) ;

         Console.WriteLine("O valor médio é: {0} ", media);
         Console.ReadKey();
      }
   }
}