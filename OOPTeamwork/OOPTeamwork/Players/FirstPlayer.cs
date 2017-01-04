using OOPTeamwork.GameAbstracts;
using OOPTeamwork.GameStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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

            GameField.inputSelection[position - 1] = Constants.FirstPlayerSymol;

            GameField.PrintFieldBorders();
        }

    }
}
