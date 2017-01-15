using System;

using OOPTeamwork.Common;
using OOPTeamwork.Core;
using OOPTeamwork.Core.Contracts;
using OOPTeamwork.Models.GameAbstracts;
using OOPTeamwork.Models.Players;

namespace OOPTeamwork.Models.Levels
{
    public class FirstLevel : Level
    {
        private readonly ManualPlayer firstPlayer = new ManualPlayer(Constants.FirstPlayerIndex, Constants.FirstPlayerSymbol);

        private readonly ManualPlayer secondPlayer = new ManualPlayer(Constants.SecondPlayerIndex, Constants.SecondPlayerSymbol);
       
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
                
                this.PrintGameField(this.GameField.PrintGameField());

                this.flag = GameLogic.CheckForWinner();
                this.CheckWhoIsTheWinner(this.flag, this.player);

                if (this.flag == 1 || this.flag == -1)
                {
                    break;
                }

                this.secondPlayer.PlayerNextMove();
                this.player++;

                this.PrintGameField(this.GameField.PrintGameField());

                GameLogic.CheckForWinner();
                this.flag = GameLogic.CheckForWinner();
                this.CheckWhoIsTheWinner(this.flag, this.player);
            }

            Result.Instance.PlayerWin(this.player);
            this.Writer.WriteLine(Result.Instance.PrintResult());
        }
    }
}
