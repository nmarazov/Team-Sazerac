using System;

using OOPTeamwork.Common;

namespace OOPTeamwork.Core
{
    public class GameLogic
    {       
        public static bool IsPosTaken(int position)
        {
            if (GameField.Instance.InputSelection[position - 1] == Constants.FirstPlayerSymbol || GameField.Instance.InputSelection[position - 1] == Constants.SecondPlayerSymbol)
            {
                Console.WriteLine("This position is already taken!");
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
            if (GameField.Instance.InputSelection[0] == GameField.Instance.InputSelection[1]
                && GameField.Instance.InputSelection[1] == GameField.Instance.InputSelection[2])
            {
                return 1;
            }

            // Winning Condition For Second Row   
            else if (GameField.Instance.InputSelection[3] == GameField.Instance.InputSelection[4]
                && GameField.Instance.InputSelection[4] == GameField.Instance.InputSelection[5])
            {
                return 1;
            }

            // Winning Condition For Third Row
            else if (GameField.Instance.InputSelection[6] == GameField.Instance.InputSelection[7] 
                && GameField.Instance.InputSelection[7] == GameField.Instance.InputSelection[8])
            {
                return 1;
            }
          
            // Winning Condition For First Column
            else if (GameField.Instance.InputSelection[0] == GameField.Instance.InputSelection[3] 
                && GameField.Instance.InputSelection[3] == GameField.Instance.InputSelection[6])
            {
                return 1;
            }

            // Winning Condition For Second Column
            else if (GameField.Instance.InputSelection[1] == GameField.Instance.InputSelection[4]
                && GameField.Instance.InputSelection[4] == GameField.Instance.InputSelection[7])
            {
                return 1;
            }

            // Winning Condition For Third Column
            else if (GameField.Instance.InputSelection[2] == GameField.Instance.InputSelection[5]
                && GameField.Instance.InputSelection[5] == GameField.Instance.InputSelection[8])
            {
                return 1;
            }

            // Winning Condition For left diagonal
            else if (GameField.Instance.InputSelection[0] == GameField.Instance.InputSelection[4]
                && GameField.Instance.InputSelection[4] == GameField.Instance.InputSelection[8])
            {
                return 1;
            }

            // Winning Condition For right diagonal
            else if (GameField.Instance.InputSelection[2] == GameField.Instance.InputSelection[4]
               && GameField.Instance.InputSelection[4] == GameField.Instance.InputSelection[6])
            {
                return 1;
            }

            // If all the cells or values filled with X or O the result is draw
            else if (
                GameField.Instance.InputSelection[0] != '1' 
                && GameField.Instance.InputSelection[1] != '2' 
                && GameField.Instance.InputSelection[2] != '3' 
                && GameField.Instance.InputSelection[3] != '4'
                && GameField.Instance.InputSelection[4] != '5' 
                && GameField.Instance.InputSelection[5] != '6'
                && GameField.Instance.InputSelection[6] != '7' 
                && GameField.Instance.InputSelection[7] != '8'
                && GameField.Instance.InputSelection[8] != '9')
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
