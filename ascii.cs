using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main()
    {
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine().ToUpper();
       
        for (int i = 0; i < H; i++) {
            string ROW = Console.ReadLine();
            foreach (char c in T)
            {
                int index = char.IsLetter(c) ? c - 'A' : 26;
                Console.Write(ROW.Substring(index * L, L));
            }
            Console.WriteLine();
        }
    }
}