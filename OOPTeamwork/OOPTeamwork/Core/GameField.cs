using System;

namespace OOPTeamwork.GameStructure
{
    public struct GameField
    {
        // array on ints - the numbers indicate the position of the current player
        public static char[] InputSelection = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public static void PrintFieldBorders()
        {
            Console.Clear();
            
            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", InputSelection[0], InputSelection[1], InputSelection[2]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", InputSelection[3], InputSelection[4], InputSelection[5]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", InputSelection[6], InputSelection[7], InputSelection[8]);

            Console.WriteLine("     |     |      ");

            Console.WriteLine();
        }
    }
}
