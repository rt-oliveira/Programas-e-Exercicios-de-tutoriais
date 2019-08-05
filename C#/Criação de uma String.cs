using System;

namespace AplicacaoString {
   class Program {
      static void Main(string[] args) {
         // Criação de string a partir de uma string literal.
         string primeironome, ultimonome;
         primeironome = "Rowan";
         ultimonome = "Atkinson";
			
         char [] letras= { 'H', 'e', 'l', 'l','o' };
         string [] vetor_strings={ "Hello", "From", "Tutorials", "Point" };
         
         // Criação de string a partir de concatenação de outras strings.
         string nomecompleto = primeironome + ultimonome;
         Console.WriteLine("Nome Completo: {0}", nomecompleto);
         
         // Criação de string a partir de um vetor de caracteres.
         string saudacao = new string(letras);
         Console.WriteLine("Saudação: {0}", saudacao);
         
         // Métodos que retornam uma string.
         string mensagem = String.Join(" ", vetor_strings);
         Console.WriteLine("Mensagem: {0}", mensagem);
         
         // Método de formatação, para fins de conversão de valores.
         DateTime hora = new DateTime(2012, 10, 10, 17, 58, 1);
         string chat = String.Format("Mensagem enviada a {0:t} do dia {0:D}", hora);
         Console.WriteLine("Mensagem: {0}", chat);
      }
   }
}