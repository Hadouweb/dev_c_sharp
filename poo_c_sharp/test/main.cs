using System;

class Program
{
	static void Main()
	{
		Guerrier war = new Guerrier("Thrall");
		Personnage hero = (Personnage)war;
		hero.Attaque();
		int nbr = 10;
		test(nbr);
		Console.WriteLine(nbr);
	}

	public static void test(int nbr)
	{
		nbr *= 2;
	}
}

class Personnage
{
	public Personnage()
	{
		Console.WriteLine("Constructeur Personnage");
	}

	public Personnage(string nom)
	{
		Console.WriteLine("Constructeur Personnage " + nom);
	}

	public virtual void Attaque()
	{
		Console.WriteLine("Attaque du personnage");
	}
}

class Guerrier : Personnage
{
	public Guerrier()
	{
		Console.WriteLine("Constructeur Guerrier");
	}

	public Guerrier(string nom)
	{
		Console.WriteLine("Constructeur Guerrier " + nom);
	}

	public override void Attaque()
	{
		Console.WriteLine("Attaque du guerrier");
	}
}