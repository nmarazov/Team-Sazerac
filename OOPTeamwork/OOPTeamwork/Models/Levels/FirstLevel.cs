using System;
using System.CodeDom;
using OOPTeamwork.Core;
using OOPTeamwork.Core.Contracts;
using OOPTeamwork.Models.GameAbstracts;
using OOPTeamwork.Models.Players;

namespace OOPTeamwork.Models.Levels
{
    public class FirstLevel : Level
    {
        private GameLogic startGameLogic = new GameLogic();

        private readonly FirstPlayer firstPlayer = new FirstPlayer();

        private readonly SecondPlayer secondPlayer = new SecondPlayer();

        private int player = 1;

        private int flag = 0;

        public FirstLevel(IGameField gameField, IWriter writer, IReader reader)
            : base(gameField, writer, reader)
        {
        }
        
        public override void StartLevel()
        {
            this.Writer.WriteLine(this.GameField.PrintGameField());

            while (this.flag != 1 && this.flag != -1)
            {
                this.player = 1;
                this.firstPlayer.PlayerNextMove();

                this.Writer.Clear();
                this.Writer.WriteLine(this.GameField.PrintGameField());

                this.flag = GameLogic.CheckForWinner();
                this.CheckWhoIsTheWinner(this.flag);

                if (this.flag == 1 || this.flag == -1)
                {
                    break;
                }

                this.secondPlayer.PlayerNextMove();
                this.player++;

                this.Writer.Clear();
                this.Writer.WriteLine(this.GameField.PrintGameField());

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
