using OOPTeamwork.GameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPTeamwork.Players;
using System.Threading;


namespace OOPTeamwork.GameStructure
{
    public class GameLogic
    {
        //Check if the chosen position is free
        //TODO: The message is showing but the method is not working properly, because it doesn't prompt the current user to select a new position, it switches to the next player.
        //Perhaps the method should be called in a while loop in PlayerNextMove()

        public static bool CheckIfPositionIsTaken(int position)
        {
            if (GameField.inputSelection[position - 1] == Constants.FirstPlayerSymol || GameField.inputSelection[position - 1] == Constants.SecondPlayerSymbol)
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
        
        //Checks if there is a winning condition or if the result is draw, if none of the conditions are satisfied, the game continues.    
        public static int CheckForWinner()
        {
            //Winning Condition For Second Row   
            if (GameField.inputSelection[0] == GameField.inputSelection[1]
                && GameField.inputSelection[1] == GameField.inputSelection[2])
            {
                return 1;
            }

            //Winning Condition For Second Row   
            else if (GameField.inputSelection[3] == GameField.inputSelection[4]
                && GameField.inputSelection[4] == GameField.inputSelection[5])
            {
                return 1;
            }

            //Winning Condition For Third Row   
            else if (GameField.inputSelection[6] == GameField.inputSelection[7] 
                && GameField.inputSelection[7] == GameField.inputSelection[8])
            {
                return 1;
            }
          
            //Winning Condition For First Column       
            else if (GameField.inputSelection[0] == GameField.inputSelection[3] 
                && GameField.inputSelection[3] == GameField.inputSelection[6])
            {
                return 1;
            }

            //Winning Condition For Second Column  
            else if (GameField.inputSelection[1] == GameField.inputSelection[4]
                && GameField.inputSelection[4] == GameField.inputSelection[7])
            {
                return 1;
            }

            //Winning Condition For Third Column  
            else if (GameField.inputSelection[2] == GameField.inputSelection[5]
                && GameField.inputSelection[5] == GameField.inputSelection[8])
            {
                return 1;
            }

            //Winning Condition For left diagonal
            else if (GameField.inputSelection[0] == GameField.inputSelection[4]
                && GameField.inputSelection[4] == GameField.inputSelection[8])
            {
                return 1;
            }

            //Winning Condition For right diagonal
            else if (GameField.inputSelection[2] == GameField.inputSelection[4]
               && GameField.inputSelection[4] == GameField.inputSelection[6])
            {
                return 1;
            }

            // If all the cells or values filled with X or O the result is draw

            else if (
                GameField.inputSelection[0] != '1' 
                && GameField.inputSelection[1] != '2' 
                && GameField.inputSelection[2] != '3' 
                && GameField.inputSelection[3] != '4'
                && GameField.inputSelection[4] != '5' 
                && GameField.inputSelection[5] != '6'
                && GameField.inputSelection[6] != '7' 
                && GameField.inputSelection[7] != '8'
                && GameField.inputSelection[8] != '9')
       
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
