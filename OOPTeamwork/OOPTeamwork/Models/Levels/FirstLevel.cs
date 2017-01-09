using System;
using OOPTeamwork.Core;
using OOPTeamwork.Models.GameAbstracts;
using OOPTeamwork.Models.Players;

namespace OOPTeamwork.Models.Levels
{
    public class FirstLevel : Level
    {
        private GameLogic startGameLogic = new GameLogic();

        private FirstPlayer firstPlayer = new FirstPlayer();

        private SecondPlayer secondPlayer = new SecondPlayer();

        private int player = 1;

        private int flag = 0;

        public override void StartLevel()
        {
            while (this.flag != 1 && this.flag != -1)
            {
                this.player = 1;

                this.firstPlayer.PlayerNextMove();
               
                GameField.PrintFieldBorders();

                this.flag = GameLogic.CheckForWinner();

                this.CheckWhoIsTheWinner(this.flag);

                if (this.flag == 1 || this.flag == -1)
                {
                    break;
                }

                this.secondPlayer.PlayerNextMove();
                this.player++;
               
                GameField.PrintFieldBorders();

                GameLogic.CheckForWinner();

                this.flag = GameLogic.CheckForWinner();

                this.CheckWhoIsTheWinner(this.flag);
            }
        }

        public void CheckWhoIsTheWinner(int flag)
        {
            if (flag == 1)
            {
                var winningPlayer = this.player % 2;

                if (winningPlayer == 0)
                {
                    winningPlayer = Constants.SecondPlayerIndex;
                }
               
                Console.WriteLine($"Player { winningPlayer } wins!");
            }
            else if (this.flag == -1)
            {
                Console.WriteLine("Draw");
            }
        }       
    }
}
