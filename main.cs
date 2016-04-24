using System;
using System.Collections.Generic;

public class Hello
{

	public static void Main()
	{
		int[] nbr = get_tab_mult(2);
		List<int> lst = get_list_mult(10);
		foreach (int node in lst)
		{
			Console.WriteLine(node);
		}
		Console.WriteLine(nbr[1]);
	}

	static int[] get_tab_mult(int nbr)
	{
		int[] 	tab = new int[] {30, 100};

		for (int i = 0; i < tab.Length; i++)
		{
			tab[i] *= nbr;
		}
		return tab;
	}

	static List<int> get_list_mult(int nbr)
	{
		List<int> lst = new List<int>();
		lst.Add(2);
		lst.Add(10);

		foreach (int node in lst)
		{
			lst.Find(node).Value *= nbr;	
		}
		return lst;
	}

}