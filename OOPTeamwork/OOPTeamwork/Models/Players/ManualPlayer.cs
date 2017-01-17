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

            int position = 0;

            try
            {
                position = int.Parse(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                this.PlayerNextMove();
            }


            if (GameLogic.ChekIfThePositionExist(position))
            {
                if (GameLogic.IsPosTaken(position) == false)
                {
                    GameField.Instance.InputSelection[position - 1] = this.PlayerSymbol;
                }
                else
                {
                    this.PlayerNextMove();
                }
            }
            else
            {
                this.PlayerNextMove();
            }                                    
        }
    }
}
