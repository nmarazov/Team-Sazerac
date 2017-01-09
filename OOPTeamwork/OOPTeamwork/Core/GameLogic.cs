using System;
using System.Threading;
using OOPTeamwork.Players;

namespace OOPTeamwork.GameStructure
{
    public class GameLogic
    {
        // Check if the chosen position is free
        // TODO: The message is showing but the method is not working properly, because it doesn't prompt the current user to select a new position, it switches to the next player.
        // Perhaps the method should be called in a while loop in PlayerNextMove()
        public static bool CheckIfPositionIsTaken(int position)
        {
            if (GameField.InputSelection[position - 1] == Constants.FirstPlayerSymol || GameField.InputSelection[position - 1] == Constants.SecondPlayerSymbol)
            {
                Console.WriteLine("This position is already taken!");
                Thread.Sleep(1000);
                return true;
            }
            else
            {
                return false;
            }             
        }
        
        // Checks if there is a winning condition or if the result is draw, if none of the conditions are satisfied, the game continues.    
        public static int CheckForWinner()
        {
            // Winning Condition For Second Row   
            if (GameField.InputSelection[0] == GameField.InputSelection[1]
                && GameField.InputSelection[1] == GameField.InputSelection[2])
            {
                return 1;
            }

            // Winning Condition For Second Row   
            else if (GameField.InputSelection[3] == GameField.InputSelection[4]
                && GameField.InputSelection[4] == GameField.InputSelection[5])
            {
                return 1;
            }

            // Winning Condition For Third Row
            else if (GameField.InputSelection[6] == GameField.InputSelection[7] 
                && GameField.InputSelection[7] == GameField.InputSelection[8])
            {
                return 1;
            }
          
            // Winning Condition For First Column
            else if (GameField.InputSelection[0] == GameField.InputSelection[3] 
                && GameField.InputSelection[3] == GameField.InputSelection[6])
            {
                return 1;
            }

            // Winning Condition For Second Column
            else if (GameField.InputSelection[1] == GameField.InputSelection[4]
                && GameField.InputSelection[4] == GameField.InputSelection[7])
            {
                return 1;
            }

            // Winning Condition For Third Column
            else if (GameField.InputSelection[2] == GameField.InputSelection[5]
                && GameField.InputSelection[5] == GameField.InputSelection[8])
            {
                return 1;
            }

            // Winning Condition For left diagonal
            else if (GameField.InputSelection[0] == GameField.InputSelection[4]
                && GameField.InputSelection[4] == GameField.InputSelection[8])
            {
                return 1;
            }

            // Winning Condition For right diagonal
            else if (GameField.InputSelection[2] == GameField.InputSelection[4]
               && GameField.InputSelection[4] == GameField.InputSelection[6])
            {
                return 1;
            }

            // If all the cells or values filled with X or O the result is draw
            else if (
                GameField.InputSelection[0] != '1' 
                && GameField.InputSelection[1] != '2' 
                && GameField.InputSelection[2] != '3' 
                && GameField.InputSelection[3] != '4'
                && GameField.InputSelection[4] != '5' 
                && GameField.InputSelection[5] != '6'
                && GameField.InputSelection[6] != '7' 
                && GameField.InputSelection[7] != '8'
                && GameField.InputSelection[8] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
