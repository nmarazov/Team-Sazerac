using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPTeamwork
{
    public struct GameField
    {
        public static char[] inputSelection = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public static void PrintFieldBorders()
        {
            

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", inputSelection[1], inputSelection[2], inputSelection[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", inputSelection[4], inputSelection[5], inputSelection[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", inputSelection[7], inputSelection[8], inputSelection[9]);

            Console.WriteLine("     |     |      ");

        }


    }
}
