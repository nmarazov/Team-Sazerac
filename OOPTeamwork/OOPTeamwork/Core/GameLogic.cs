using System;

using OOPTeamwork.Common;

namespace OOPTeamwork.Core
{
    public class GameLogic
    {       
        public static bool IsPosTaken(int position)
        {
            if (GameField.Instance.InputSelection[position - 1] == Constants.FirstPlayerSymbol
                || GameField.Instance.InputSelection[position - 1] == Constants.SecondPlayerSymbol)
            {
                Console.WriteLine("This position is already taken!");
                return true;
            }
            else
            {
                return false;
            }             
        }
        
        public static bool ChekIfThePositionExist(int position)
        {
            if (position >= 1 && position <= 9) { return true; }
            else
            {
                Console.WriteLine("The positions are from 1 to 9.");
                return false;
            }
        }
        
        // Checks if there is a winning condition or if the result is draw, if none of the conditions are satisfied, the game continues.    
        public static int CheckForWinner()
        {
            // Winning Condition For First Row, Second Row, Third Row, First Column, Second Column, Third Column, Left Diagonal, Right Diagonal
            if ((GameField.Instance.InputSelection[0] == GameField.Instance.InputSelection[1] && GameField.Instance.InputSelection[1] == GameField.Instance.InputSelection[2])
                || (GameField.Instance.InputSelection[3] == GameField.Instance.InputSelection[4] && GameField.Instance.InputSelection[4] == GameField.Instance.InputSelection[5])
                || (GameField.Instance.InputSelection[6] == GameField.Instance.InputSelection[7] && GameField.Instance.InputSelection[7] == GameField.Instance.InputSelection[8])
                || (GameField.Instance.InputSelection[0] == GameField.Instance.InputSelection[3] && GameField.Instance.InputSelection[3] == GameField.Instance.InputSelection[6])
                || (GameField.Instance.InputSelection[1] == GameField.Instance.InputSelection[4] && GameField.Instance.InputSelection[4] == GameField.Instance.InputSelection[7])
                || (GameField.Instance.InputSelection[2] == GameField.Instance.InputSelection[5] && GameField.Instance.InputSelection[5] == GameField.Instance.InputSelection[8])
                || (GameField.Instance.InputSelection[0] == GameField.Instance.InputSelection[4] && GameField.Instance.InputSelection[4] == GameField.Instance.InputSelection[8])
                || (GameField.Instance.InputSelection[2] == GameField.Instance.InputSelection[4] && GameField.Instance.InputSelection[4] == GameField.Instance.InputSelection[6])
                )
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
