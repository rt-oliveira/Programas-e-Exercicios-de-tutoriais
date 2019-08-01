using System;

namespace AplicacaoArray {
   class MeuArray {
      static void Main(string[] args) {
         int[] lista = { 34, 72, 13, 44, 25, 30, 10 };
         int[] temp = lista;
         Console.Write("Vetor original: ");
         
         foreach (int i in lista) {
            Console.Write(i + " ");
         }
         Console.WriteLine();
         
         // Está revertendo o vetor
         Array.Reverse(temp);
         Console.Write("Vetor revertido: ");
         
         foreach (int i in temp) {
            Console.Write(i + " ");
         }
         Console.WriteLine();
         
         // Ordenando o vetor
         Array.Sort(lista);
         Console.Write("Vetor ordenado: ");
         
         foreach (int i in lista) {
            Console.Write(i + " ");
         }
         Console.WriteLine();
         Console.ReadKey();
      }
   }
}