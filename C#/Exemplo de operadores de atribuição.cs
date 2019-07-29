using System;

namespace OperatorsAppl {

   class Program {
   
      static void Main(string[] args) {
         int a = 21;
         int c;
         c = a;
         Console.WriteLine("Linha 1 - =  Valor de c é = {0}", c);

		 /* Cada um dos operadores a seguir fazem uma operação (matemática ou bitwise),
		  * além de colocar o resultado na variável a receber o resultado.
		  *
		  * Exemplo: 					c += a;
		  * Este comando se equivale a:	c = c + a;
		  */
         
         c += a;
         Console.WriteLine("Linha 2 - += Valor de c é = {0}", c);
         
         c -= a;
         Console.WriteLine("Linha 3 - -=  Valor de c é = {0}", c);
         
         c *= a;
         Console.WriteLine("Linha 4 - *=  Valor de c é = {0}", c);
         
         c /= a;
         Console.WriteLine("Linha 5 - /=  Valor de c é = {0}", c);
         
         c = 200;
         c %= a;
         Console.WriteLine("Linha 6 - %=  Valor de c é = {0}", c);
         
         c <<= 2;
         Console.WriteLine("Linha 7 - <<=  Valor de c é = {0}", c);
         
         c >>= 2;
         Console.WriteLine("Linha 8 - >>=  Valor de c é = {0}", c);
         
         c &= 2;
         Console.WriteLine("Linha 9 - &=  Valor de c é = {0}", c);
         
         c ^= 2;
         Console.WriteLine("Linha 10 - ^=  Valor de c é = {0}", c);
         
         c |= 2;
         Console.WriteLine("Linha 11 - |=  Valor de c é = {0}", c);
         Console.ReadLine();
      }
   }
}
