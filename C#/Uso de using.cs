using System;
using primeiro_space;
using segundo_space;

namespace primeiro_space
{
	class abc
	{
		public void func(){
			Console.WriteLine("Dentro de primeiro_space");
		}
	}
}

namespace segundo_space
{
	class efg
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
		abc fc=new abc();		
		efg sc=new efg();
		fc.func();
		sc.func();
		Console.ReadKey();
	}
}

