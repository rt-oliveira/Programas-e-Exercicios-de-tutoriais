using System;
namespace SobrecargaOperadorAplicacao{
    class Caixa{
        private double comprimento;
        private double profundidade;
        private double altura;
        public double getVolume(){
            return comprimento*profundidade*altura;
        }
        public void setComprimento(double comp){
            comprimento=comp;
        }
        public void setProfundidade(double prof){
            profundidade=prof;
        }
        public void setAltura(double alt){
            altura=alt;
        }
        // Sobrecarga do operador + para adicionar 2 objetos Caixa.
        public static Caixa operator+(Caixa a,Caixa b){
            Caixa c=new Caixa();
            c.comprimento=a.comprimento+b.comprimento;
            c.profundidade=a.profundidade+b.profundidade;
            c.altura=a.altura+b.altura;
            return c;
        }
				public static bool operator==(Caixa a,Caixa b){
					bool status=false;
					if(a.comprimento==b.comprimento && a.altura==b.altura 
							&& a.profundidade==b.profundidade)
						status=true;
					return status;
				}
				public static bool operator!=(Caixa a,Caixa b){
					bool status=false;
					if(a.comprimento!=b.comprimento || a.altura!=b.altura
							|| a.profundidade!=b.profundidade)
						status=true;
					return status;
				}
				public static bool operator<(Caixa a,Caixa b){
					bool status=false;
					if(a.comprimento<b.comprimento && a.altura<b.altura
							&& a.profundidade<b.profundidade)
						status=true;
					return status;
				}
				public static bool operator>(Caixa a,Caixa b){
					bool status=false;
					if(a.comprimento>b.comprimento && a.altura>b.altura
							&& a.profundidade>b.profundidade)
						status=true;
					return status;
				}
				public static bool operator<=(Caixa a,Caixa b){
					bool status=false;
					if(a.comprimento<=b.comprimento && a.altura<=b.altura
							&& a.profundidade<=b.profundidade)
						status=true;
					return status;
				}
				public static bool operator>=(Caixa a,Caixa b){
					bool status=false;
					if(a.comprimento>=b.comprimento && a.altura>=b.altura
							&& a.profundidade>=b.profundidade)
						status=true;
					return status;
				}
				public override string ToString(){
					return String.Format("({0}, {1}, {2})",comprimento,profundidade,altura);
				}
    }
    class Tester{
        static void Main(string[] args){
            Caixa c1=new Caixa();
            Caixa c2=new Caixa();
            Caixa c3=new Caixa();
						Caixa c4=new Caixa();
            // Declarados 4 objetos do tipo Caixa.
            double volume=0;

            // Especificação da Caixa c1
            c1.setComprimento(6);
            c1.setProfundidade(7);
            c1.setAltura(5);

            // Especificação da Caixa c2
            c2.setComprimento(12);
            c2.setProfundidade(13);
            c2.setAltura(10);

						Console.WriteLine("Caixa 1: {0}",c1.ToString());
						Console.WriteLine("Caixa 2: {0}",c2.ToString());

            // Volumes das Caixas c1 e c2
            volume=c1.getVolume();
            Console.WriteLine("Volume da caixa c1: {0}",volume);
            volume=c2.getVolume();
            Console.WriteLine("Volume da caixa c2: {0}",volume);

            // Adição de dois objetos Caixa
            c3=c1+c2;
						Console.WriteLine("Caixa 3: {0}",c3.ToString());

            // Volume da caixa resultante (c3)
						volume=c3.getVolume();
            Console.WriteLine("Volume da caixa c3: {0}",volume);

						// Comparações com as caixas
						if(c1>c2)
							Console.WriteLine("Caixa 1 é maior que Caixa 2");
						else
							Console.WriteLine("Caixa 1 não é maior que Caixa 2");

						if(c1<c2)
							Console.WriteLine("Caixa 1 é menor que Caixa 2");
						else
							Console.WriteLine("Caixa 1 não é menor que Caixa 2");

						if(c1>=c2)
							Console.WriteLine("Caixa 1 é maior ou igual que Caixa 2");
						else
							Console.WriteLine("Caixa 1 não é maior ou igual que Caixa 2");

						if(c1<=c2)
							Console.WriteLine("Caixa 1 é menor ou igual que Caixa 2");
						else
							Console.WriteLine("Caixa 1 não é menor ou igual que Caixa 2");

						if(c1!=c2)
							Console.WriteLine("Caixa 1 é diferente da Caixa 2");
						else
							Console.WriteLine("Caixa 1 é igual a Caixa 2");

						c4=c3;

						if(c3==c4)
							Console.WriteLine("Caixa 3 é igual a Caixa 4");
						else
							Console.WriteLine("Caixa 3 é diferente da Caixa 4");

            Console.ReadKey();
        }
    }
}
