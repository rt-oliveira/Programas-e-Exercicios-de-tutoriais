using System;

namespace primeiro_space
{
	class namespace_c1
	{
		public void func(){
			Console.WriteLine("Dentro de primeiro_space");
		}
	}
}

namespace segundo_space
{
	class namespace_c1
	{
		public void func(){
			Console.WriteLine("Dentro de segundo_space");
		}	
	}
}

class ClasseTeste
{
	static void Main(string[] args)
	{
		primeiro_space.namespace_c1 fc=new primeiro_space.namespace_c1();		
		segundo_space.namespace_c1 sc=new segundo_space.namespace_c1();
		fc.func();
		sc.func();
		Console.ReadKey();
	}
}
