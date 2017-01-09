using System;
using OOPTeamwork.Core;
using OOPTeamwork.Models.GameAbstracts;

namespace OOPTeamwork.Models.Players
{
    public class SecondPlayer : Player
    {
        public SecondPlayer()
        {
            this.PlayerIndex = Constants.SecondPlayerIndex;
        }

        public override void PlayerNextMove()
        {
            Console.Write($"Player {this.PlayerIndex} select position: ");

            var position = int.Parse(Console.ReadLine());

            GameLogic.CheckIfPositionIsTaken(position);

            GameField.InputSelection[position - 1] = Constants.SecondPlayerSymbol;

            GameField.PrintFieldBorders();
        }
    }
}
