using System;

namespace AplicacaoVetor {
   class MeuVetor {
      static void Main(string[] args) {
	 // Esta é uma matriz de 5 linhas e 2 colunas.
         int[,] a = new int[5, 2] {{0,0}, {1,2}, {2,4}, {3,6}, {4,8} };
         int i, j;
         
	 // Mostrando cada elemento da matriz.
         for (i = 0; i < 5; i++) {
            for (j = 0; j < 2; j++) {
               Console.WriteLine("a[{0},{1}] = {2}", i, j, a[i,j]);
            }
         }
         Console.ReadKey();
      }
   }
}