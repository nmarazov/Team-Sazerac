using System;
using System.Text;

namespace OOPTeamwork.Core
{
    public class Result
    {
        private static Result instance;

        private int playerOneNumOfWins;
        private int playerTwoNumOfWins;

        private Result()
        {  
        }

        public static Result Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Result();
                }

                return instance;
            }
        }

        public int PlayerOneNumOfWins
        {
            get { return playerOneNumOfWins; }
            private set { playerOneNumOfWins = value; }
        }

        public int PlayerTwoNumOfWins
        {
            get { return playerTwoNumOfWins; }
            private set { playerTwoNumOfWins = value; }
        }

        public void PlayerWin(int playerNum)
        {
            if (playerNum % 2 == 1)
            {
                playerOneNumOfWins++;
            }
            if (playerNum % 2 == 0)
            {
                playerTwoNumOfWins++;
            }
        }

        public string PrintResult()
        {
            var result  = new StringBuilder();

            result.AppendLine("The result is:");
            result.AppendLine($"Red player: {PlayerOneNumOfWins} wins");
            result.AppendLine($"Blue player: {PlayerTwoNumOfWins} wins");

            return result.ToString();
        }

        public void ClearResult()
        {
            this.PlayerOneNumOfWins = 0;
            this.PlayerTwoNumOfWins = 0;
        }
    }
}
