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
        string 	MESSAGE = Console.ReadLine();
        byte[]	bytes = System.Text.Encoding.ASCII.GetBytes(MESSAGE);
        string 	tmp = "";
        char	c;
    	int		i = 0;
    	
        foreach (byte b in bytes)
        {
        	tmp += Convert.ToString(b, 2).PadLeft(7, '0');
        }
    	while (i < tmp.Length)
    	{
    		c = (tmp[i] == '1') ? '1': '0';
    		if (c == '1')
    			Console.Write("0 ");
    		else
    			Console.Write("00 ");
    		while (i < tmp.Length && tmp[i] == c)
    		{
    			Console.Write("0");
    			i++;
    		}
    		if (i >= tmp.Length)
    			break;
    		Console.Write(" ");
    	}
        Console.WriteLine();
    }
}