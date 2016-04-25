using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{
    static void Main(string[] args)
    {
        string LON = Console.ReadLine();
        string LAT = Console.ReadLine();
        int N = int.Parse(Console.ReadLine());
        string result = "";
        double dist = -1.0;
        for (int i = 0; i < N; i++)
        {
            string[] DEFIB = Console.ReadLine().Split(';');
            double new_dist = getDist(
                Convert.ToDouble(LON, new CultureInfo("fr-FR")), 
                Convert.ToDouble(LAT, new CultureInfo("fr-FR")),
                Convert.ToDouble(DEFIB[4], new CultureInfo("fr-FR")), 
                Convert.ToDouble(DEFIB[5], new CultureInfo("fr-FR")));
            if (new_dist < dist || dist == -1.0)
            {
                dist = new_dist;
                result = DEFIB[1];
            }
        }

        Console.WriteLine(result);
    }

    static double getDist(double lonA, double latA, double lonB, double latB)
    {
        double x = (lonB - lonA) * Math.Cos((latA + latB) / 2);
        double y = (latB - latA);
        double dist = Math.Sqrt((x * x) + (y * y)) * 6371;
        return dist;
    }
}