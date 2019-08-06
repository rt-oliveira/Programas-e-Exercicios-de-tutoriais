using System;

struct Livro {
   private string titulo;
   private string autor;
   private string assunto;
   private int id_livro;
   
   public void getValues(string t, string a, string s, int id) {
      titulo = t;
      autor = a;
      assunto = s;
      id_livro = id;
   }
   
   public void display() {
      Console.WriteLine("Título : {0}", titulo);
      Console.WriteLine("Autor : {0}", autor);
      Console.WriteLine("Assunto : {0}", assunto);
      Console.WriteLine("Id_livro : {0}", id_livro);
   }
};  

public class testarStruct {
   public static void Main(string[] args) {
	  // Estão sendo declarados e instanciados 2 variáveis do tipo Livro.
      Livro Livro1 = new Livro();
      Livro Livro2 = new Livro();

	  // Especificação de Livro1
      Livro1.getValues("C Programming","Nuha Ali", "C Programming Tutorial",6495407);

      // Especificação de Livro2
      Livro2.getValues("Telecom Billing","Zara Ali", "Telecom Billing Tutorial", 6495700);

	  // Mostrando informações de Livro1 e Livro2
      Livro1.display();
      Livro2.display(); 

      Console.ReadKey();
   }
}