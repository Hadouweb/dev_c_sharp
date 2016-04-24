using System;
using System.Collections.Generic;

public class Hello
{

	public static void Main()
	{
		int[] 	tab = new int[7];
		bool 	newRandom = false;
		int		nbr_tmp;
		System.Random RandNum = new System.Random();

		for (int i = 0; i < tab.Length; i++)
		{
			do 
			{
				nbr_tmp = RandNum.Next(1, 50);
				newRandom = is_double(tab, i, nbr_tmp);
			} while (newRandom);
			tab[i] = nbr_tmp;
		}
		printResult(tab);
	}

	static bool is_double(int[] tab, int max, int nbrRandom)
	{
		for (int j = 0; j < max; j++)
		{
			if (tab[j] == nbrRandom)
				return true;
		}
		return false;
	}

	static void printResult(int[] tab)
	{
		foreach (int nbr in tab)
		{
			Console.WriteLine(nbr);
		}
	}

}