using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multidimensionalArrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("multidimensional Arrays 2:");
            Console.WriteLine();

            // 2d inventory system:

            // single item example:
            string currentItem;
            currentItem = "pickaxe";

            // hot bar (1d array) example:
            string[] hotbar = new string[9];
            hotbar[0] = "pickaxe";
            hotbar[1] = ""; // empty
            hotbar[2] = ""; // empty
            // ...
            hotbar[8] = ""; // empty
            // (should be in a loop)

            // [] brackets
            // () parenthesis
            // {} braces

            // 2d inventory system:

            string[,] inventory = new string[9, 3]; // (9x3)
            inventory[0, 0] = ""; // empty
            // ...
            inventory[4, 2] = "pickaxe";
            // ...
            inventory[8, 2] = ""; // empty
            
            // how do we initialize all inventory slots to empty string ("") ?
            for (int x = 0; x <= 8; x++)
            {
                Console.Write(x);

                for (int y = 0; y <= 2; y++);
                {
                    Console.Write(x + "," + y);
                }
            }



            // 1D --> string[] hotbar = new string[9];
            //        hotbar[_]
            // 2D --> string[,] inventory = new string[9, 3];
            //        inventory[3,9]
            Console.ReadKey(true);
        }
    }
}
