using System;

using OOPTeamwork.Core;
using OOPTeamwork.Models.GameAbstracts;

namespace OOPTeamwork.Models.Players
{
    public class ManualPlayer : Player
    {
        public ManualPlayer(int playerIndex, char playerSymbol) 
            : base(playerIndex, playerSymbol)
        {
        }

        public override void PlayerNextMove()
        {
            Console.Write($"Player {this.PlayerIndex} select position: ");

            var position = int.Parse(Console.ReadLine());

            if (GameLogic.CheckIfPositionIsTaken(position) == true)
            {
                this.PlayerNextMove();
            }
            else
            {
                GameField.Instance.InputSelection[position - 1] = this.PlayerSymbol;
            }
        }
    }
}
