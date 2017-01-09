using System;
using OOPTeamwork.Core;
using OOPTeamwork.Models.GameAbstracts;

namespace OOPTeamwork.Models.Players
{
    public class FirstPlayer : Player
    {
        public FirstPlayer()
        {
            this.PlayerIndex = Constants.FirstPlayerIndex;
        }

        public override void PlayerNextMove()
        {
            Console.Write($"Player {this.PlayerIndex} select position: ");

            var position = int.Parse(Console.ReadLine());

            GameLogic.CheckIfPositionIsTaken(position);

            GameField.Instance.InputSelection[position - 1] = Constants.FirstPlayerSymol;
        }
    }
}
