using System;

namespace OOPTeamwork.Core
{
    public static class Result
    {
        private static int playerOneNumOfWins;
        private static int playerTwoNumOfWins;

        public static void PlayerWin(int playerNum)
        {
            if (playerNum == 1)
            {
                playerOneNumOfWins++;
            }
            if (playerNum == 2)
            {
                playerTwoNumOfWins++;
            }
        }

        public static void PrintResult()
        {
            Console.WriteLine("The result is:");
            Console.ForegroundColor = System.ConsoleColor.Red;
            Console.WriteLine("Player 1: {0} wins", playerOneNumOfWins);
            Console.ForegroundColor = System.ConsoleColor.Blue;
            Console.WriteLine("Player 2: {0} wins", playerTwoNumOfWins);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public static void ClearResult()
        {
            playerOneNumOfWins = 0;
            playerTwoNumOfWins = 0;
        }
    }
}
