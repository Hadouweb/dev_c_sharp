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
class Player
{
    static void Main(string[] args)
    {

        // game loop
        int[] mountainH = new int[8];
        while (true)
        {
            for (int i = 0; i < 8; i++)
            {
                mountainH[i] = int.Parse(Console.ReadLine()); // represents the height of one mountain, from 9 to 0.
            }
            Console.WriteLine(Array.IndexOf(mountainH, mountainH.Max())); // The number of the mountain to fire on.
        }
    }
}