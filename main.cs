using System;

class Program
{

	static void Main(string[] av)
	{
		Bmw car = new Bmw();
		car.Rouler();
		car.Accelerer(200);
		Console.WriteLine(car.ToString());
	}

}