using System;

using OOPTeamwork.GameAbstracts;
using OOPTeamwork.GameStructure;

namespace OOPTeamwork.Players
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

            GameField.InputSelection[position - 1] = Constants.FirstPlayerSymol;

            GameField.PrintFieldBorders();
        }
    }
}
