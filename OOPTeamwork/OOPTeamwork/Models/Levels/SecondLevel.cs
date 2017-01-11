using System;
using OOPTeamwork.Core;
using OOPTeamwork.Core.Contracts;
using OOPTeamwork.Models.Contracts;
using OOPTeamwork.Models.GameAbstracts;
using OOPTeamwork.Models.Players;

namespace OOPTeamwork.Models.Levels
{
    public class SecondLevel : Level
    {
        private readonly ManualPlayer firstPlayer = new ManualPlayer(Constants.FirstPlayerIndex, Constants.FirstPlayerSymol);

        private readonly EnemyLogic secondPlayer = new EnemyLogic(Constants.SecondPlayerIndex, Constants.SecondPlayerSymbol);

        private int player = 1;

        private int flag = 0;

        public SecondLevel(IGameField gameField, IWriter writer, IReader reader)
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
