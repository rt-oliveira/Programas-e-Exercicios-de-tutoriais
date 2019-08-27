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
    }
    class Tester{
        static void Main(string[] args){
            Caixa c1=new Caixa();
            Caixa c2=new Caixa();
            Caixa c3=new Caixa();
            // Declarados 3 objetos do tipo Caixa.
            double volume=0;

            // Especificação da Caixa c1
            c1.setComprimento(6);
            c1.setProfundidade(7);
            c1.setAltura(5);

            // Especificação da Caixa c2
            c2.setComprimento(12);
            c2.setProfundidade(13);
            c2.setAltura(10);

            // Volumes das Caixas c1 e c2
            volume=c1.getVolume();
            Console.WriteLine("Volume da caixa c1: {0}",volume);
            volume=c2.getVolume();
            Console.WriteLine("Volume da caixa c2: {0}",volume);

            // Adição de dois objetos Caixa
            c3=c1+c2;

            // Volume da caixa resultante (c3)
            volume=c3.getVolume();
            Console.WriteLine("Volume da caixa c3: {0}",volume);
            Console.ReadKey();
        }
    }
}
