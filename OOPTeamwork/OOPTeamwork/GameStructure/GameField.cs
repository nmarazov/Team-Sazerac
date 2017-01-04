using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPTeamwork
{
    public struct GameField
    {
        //array on ints - the numbers indicate the position of the current player
        public static char[] inputSelection = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public static void PrintFieldBorders()
        {
            Console.Clear();
            
            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", inputSelection[0], inputSelection[1], inputSelection[2]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", inputSelection[3], inputSelection[4], inputSelection[5]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", inputSelection[6], inputSelection[7], inputSelection[8]);

            Console.WriteLine("     |     |      ");
        }
    }
}
