using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OOPTeamwork.Players;
using OOPTeamwork.GameAbstracts;

namespace OOPTeamwork.GameStructure
{
    public class FirstLevel : Level
    {
        GameLogic startGameLogic = new GameLogic();

        FirstPlayer firstPlayer = new FirstPlayer();

        SecondPlayer secondPlayer = new SecondPlayer();

        int player = 1;

        int flag = 0;

        public override void StartLevel()
        {

            while (flag != 1 && flag != -1)
            {
                player = 1;

                firstPlayer.PlayerNextMove();
               
                GameField.PrintFieldBorders();

                flag = GameLogic.CheckForWinner();

                CheckWhoIsTheWinner(flag);

                if (flag == 1 || flag == -1)
                {
                    break;
                }

                secondPlayer.PlayerNextMove();
                player++;
               
                GameField.PrintFieldBorders();

                GameLogic.CheckForWinner();

                flag = GameLogic.CheckForWinner();

                CheckWhoIsTheWinner(flag);
            }
        }

        public void CheckWhoIsTheWinner(int flag)
        {
            if (flag == 1)
            {
                var winningPlayer = player % 2;

                if (winningPlayer == 0)
                {
                    winningPlayer = Constants.SecondPlayerIndex;
                }
               
                Console.WriteLine($"Player { winningPlayer } wins!");
            }

            else if (flag == -1)
            {
                Console.WriteLine("Draw");
            }
        }       
    }
}
