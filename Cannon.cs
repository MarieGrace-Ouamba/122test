using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMagicCannon
{
    public class Cannon
    {
        public static void FireCannon(int turn)
        {
            string result = $"{turn}: ";

            if (turn % 3 == 0 && turn % 5 == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                result += "Fire and Electric!";
            }
            else if (turn % 3 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                result += "Fire";
            }
            else if (turn % 5 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                result += "Electric";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                result += "Normal";
            }

            Console.WriteLine(result);
            
        }
    }
}
