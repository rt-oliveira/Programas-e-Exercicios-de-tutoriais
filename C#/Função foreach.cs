using System;

namespace AplicacaoVetores {
   class MeuVetor{
      static void Main(string[] args) {
         int []  n = new int[10];
         
         for ( int i = 0; i < 10; i++ ) {
            n[i] = i + 100;
         }
         
	 // Mostrando cada elemento do vetor.
         foreach (int j in n ) {
            int i = j-100;
            Console.WriteLine("Element[{0}] = {1}", i, j);
         }
         Console.ReadKey();
      }
   }
}