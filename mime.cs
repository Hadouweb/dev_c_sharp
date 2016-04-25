using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

class Solution
{
    static void Main(string[] args)
    {
        int mimeTypeNB = int.Parse(Console.ReadLine());
        int fileNB = int.Parse(Console.ReadLine());
        Dictionary<string, string> mimeDico = new Dictionary<string, string>();

        for (int i = 0; i < mimeTypeNB; i++)
        {
            string[] inputs = Console.ReadLine().Split(' ');
            mimeDico.Add(inputs[0].ToUpper(), inputs[1]);
        }

        for (int i = 0; i < fileNB; i++)
        {
            string[] str = Console.ReadLine().Split('.');
            Console.WriteLine(mimeDico.ContainsKey(str.Last().ToUpper()) && str.Length != 1 ? mimeDico[str.Last().ToUpper()] : "UNKNOWN");
        }
    }
}