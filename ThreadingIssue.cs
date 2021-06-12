
using System;
using System.Threading;

public class MyClass
{
	public static int num = 1;
	public static bool flag = false;
	// public static void Main()
	// {
	// 	Thread t= new Thread(new ThreadStart(new MyThread().Run));
    //     t.Start();
    //     MyClass.flag = true;
	// 	MyClass.num = 10;
	// }
}

class MyThread
{
	public void Run()
	{
		while (!MyClass.flag)
		{
			Thread.Yield();
		}

		Console.WriteLine(MyClass.num);
	}
}