using System;

struct Livro {
   public string titulo;
   public string autor;
   public string assunto;
   public int id_livro;
};  

public class testStructure {
   public static void Main(string[] args) {
	  // Declara��o de vari�veis do tipo Livro
      Livro Livro1;
      Livro Livro2;

      // Especifica��o do Livro1
      Livro1.titulo = "C Programming";
      Livro1.autor = "Nuha Ali"; 
      Livro1.assunto = "C Programming Tutorial";
      Livro1.id_livro = 6495407;

      // Especifica��o do Livro2
      Livro2.titulo = "Telecom Billing";
      Livro2.autor = "Zara Ali";
      Livro2.assunto =  "Telecom Billing Tutorial";
      Livro2.id_livro = 6495700;

      // Mostrando informa��es de Livro1
      Console.WriteLine("T�tulo do Livro 1 : {0}", Livro1.titulo);
      Console.WriteLine("Autor do Livro 1 : {0}", Livro1.autor);
      Console.WriteLine("Assunto do Livro 1 : {0}", Livro1.assunto);
      Console.WriteLine("id_livro do Livro 1 :{0}", Livro1.id_livro);
	  
	  // Mostrando informa��es de Livro2
	  Console.WriteLine("T�tulo do Livro 2 : {0}", Livro2.titulo);
      Console.WriteLine("Autor do Livro 2 : {0}", Livro2.autor);
      Console.WriteLine("Assunto do Livro 2 : {0}", Livro2.assunto);
      Console.WriteLine("id_livro do Livro 2 :{0}", Livro2.id_livro);
	  
      Console.ReadKey();
   }
}