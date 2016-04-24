using System;
using System.Linq;

class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var temps = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries);

        var result = temps.Select(int.Parse)
            .OrderBy(Math.Abs)
            .ThenByDescending(x => x)
            .FirstOrDefault();

        Console.WriteLine(result);
    }
}