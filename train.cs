using System;
// ReSharper disable AssignNullToNotNullAttribute
// ReSharper disable PossibleNullReferenceException

class Solution
{
    static void Main()
    {
        int L = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        string T = Console.ReadLine().ToUpper();
       
        for (int i = 0; i < H; i++) {
            string ROW = Console.ReadLine();
            foreach (char letter in T)
            {
                int index = char.IsLetter(letter) ? letter - 'A' : 26;
                Console.Write(ROW.Substring(index * L,L));
            }
            Console.WriteLine();
        }
    }
}