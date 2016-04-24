using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 * ---
 * Hint: You can use the debug stream to print initialTX and initialTY, if Thor seems not follow your orders.
 **/
class Player
{
    static void Main(string[] args)
    {
        string[] inputs = Console.ReadLine().Split(' ');
        int lightX = int.Parse(inputs[0]); // the X position of the light of power
        int lightY = int.Parse(inputs[1]); // the Y position of the light of power
        int thorX = int.Parse(inputs[2]); // Thor's starting X position
        int thorY = int.Parse(inputs[3]); // Thor's starting Y position

        // game loop
        while (true)
        {
            int remainingTurns = int.Parse(Console.ReadLine());

            string direction = "";
            if(thorY > lightY) {
                direction = "N";
                thorY--;
            } else if(thorY < lightY ) {
                direction = "S";
                thorY++;
            }
            
            if(thorX > lightX) {
                direction = direction + "W";
                thorX--;
            } else if(thorX < lightX ) {
                direction = direction + "E";
                thorX++;
            }

            Console.WriteLine(direction); // A single line providing the move to be made: N NE E SE S SW W or NW
        }
    }
}