using System;

namespace OOPTeamwork.Core
{
    public class Result
    {
        private int playerOneNumOfWins;
        private int playerTwoNumOfWins;

        public int PlayerOneNumOfWins
        {
            get { return playerOneNumOfWins; }
            private set { playerOneNumOfWins = value; }
        }
        public int PlayerTwoNumOfWins
        {
            get { return playerTwoNumOfWins; }
            private set { playerOneNumOfWins = value; }
        }

        public void PlayerWin(int playerNum)
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
        public void PrintResult()
        {
            Console.WriteLine("The result is:");
            Console.ForegroundColor = System.ConsoleColor.Red;
            Console.WriteLine("Player 1: {0} wins", PlayerOneNumOfWins);
            Console.ForegroundColor = System.ConsoleColor.Blue;
            Console.WriteLine("Player 2: {0} wins", PlayerTwoNumOfWins);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        public void ClearResult()
        {
            this.PlayerOneNumOfWins = 0;
            this.PlayerTwoNumOfWins = 0;
        }
    }
}
