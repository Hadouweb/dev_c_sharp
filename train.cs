using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;


class Solution
{
    static void Main()
    {

        
        StringBuilder   BinaryMessage = new StringBuilder(),    
                        ChuckNorrisMessage = new StringBuilder();
                        
        String Sentence = Console.ReadLine();

        char LastBit = default(char);

        foreach (char c in Sentence)
        {
            BinaryMessage.Append(Convert.ToString(c, 2).PadLeft(7, '0'));
        }

        foreach(char bit in BinaryMessage.ToString())
        {
            ChuckNorrisMessage.Append(bit != LastBit ? (bit=='1'?" 0 0":" 00 0") : "0");
            LastBit = bit;
        }
        Console.WriteLine(ChuckNorrisMessage.ToString().Trim());
    }
}
