using OOPTeamwork.GameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPTeamwork.Players;


namespace OOPTeamwork.GameStructure
{
    public class GameLogic : IGameLogic
    {
        public void CheckIfPositionIsTaken(int position)
        {
            while (true)
            {
                if (position == Constants.FirstPlayerSymol || position == Constants.SecondPlayerSymbol)
                {
                    Console.WriteLine("This position is already taken!");
                }
                else
                {
                    break;
                }
            }
        }

        public void PlayerNextMove()
        {

            for (int i = 0; i < Constants.NumberOfPlayers; i++)
            {
                if (i == 0)
                {
                    Console.Write($"Player {i} select position: ");
                    var position = int.Parse(Console.ReadLine());

                    CheckIfPositionIsTaken(position);

                    GameField.inputSelection[position] = Constants.FirstPlayerSymol;

                    GameField.PrintFieldBorders();

                }

                else if (i==1)
                {
                    Console.Write($"Player {i} select position: ");
                    var position = int.Parse(Console.ReadLine());

                    CheckIfPositionIsTaken(position);

                    GameField.inputSelection[position] = Constants.SecondPlayerSymbol;

                    GameField.PrintFieldBorders();
                }
            }
        }
    }
}
