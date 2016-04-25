using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] pi_tab = new int[N];
        for (int i = 0; i < N; i++)
        {
            pi_tab[i] = int.Parse(Console.ReadLine());
        }
        Array.Sort(pi_tab);
        int dist = pi_tab[1] - pi_tab[0];
        for (int i = 1; i < N; i++)
        {
            int new_dist = Math.Abs(pi_tab[i] - pi_tab[i - 1]);
            if (new_dist < dist)
                dist = new_dist;
        }
        Console.WriteLine(dist);
    }
}