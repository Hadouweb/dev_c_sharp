using System;

class Program
{
    private static Random random = new Random();

	static void Main(string[] args)
	{
		Jeu1();
		Jeu2();
	}

	private static void Jeu1()
	{
		Joueur nicolas = new Joueur(150);
		int cptFacile = 0;
		int cptDifficile = 0;
		while (nicolas.EstVivant)
		{
			MonstreFacile monstre = FabriqueDeMonstre();
			while (monstre.EstVivant && nicolas.EstVivant)
			{
				nicolas.Attaque(monstre);
				if (monstre.EstVivant)
					monstre.Attaque(nicolas);
			}

			if (nicolas.EstVivant)
			{
				if (monstre is MonstreDifficile)
					cptDifficile++;
				else
					cptFacile++;
			}
			else
			{
				Console.WriteLine("Snif, vous êtes mort...");
				break;
			}
		}
		Console.WriteLine("Bravo !!! Vous avez tué {0} monstres faciles et {1} monstres difficiles. Vous avez {2} points.", cptFacile, cptDifficile, cptFacile + cptDifficile * 2);
	}

	private static void Jeu2()
	{
		Joueur nicolas = new Joueur(150);
		Boss boss = new Boss(250);
		while (nicolas.EstVivant && boss.EstVivant)
		{
			nicolas.Attaque(boss);
			if (boss.EstVivant)
				boss.Attaque(nicolas);
		}
		if (nicolas.EstVivant)
			Console.WriteLine("Bravo, vous avez sauvé la princesse (ou le prince !)");
		else
			Console.WriteLine("Game over...");
	}

	private static MonstreFacile FabriqueDeMonstre()
	{
		if (random.Next(2) == 0)
			return new MonstreFacile();
		else
			return new MonstreDifficile();
	}
}