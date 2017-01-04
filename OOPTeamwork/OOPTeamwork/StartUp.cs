using OOPTeamwork.GameStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeamwork
{
    public class StartUp
    {
        public static void Main()
        {
            
            LevelSelection level = new LevelSelection();

            var selectedLevel = level.SelectLevel();
            
            if (selectedLevel == (int)(LevelType.one))
            {
                Console.WriteLine("test1");
                GameField.PrintFieldBorders();
            }

            else if (selectedLevel == (int)(LevelType.two))
            {
                Console.WriteLine("test2");
                GameField.PrintFieldBorders();
            }

            else
            {
                throw new ArgumentException("Please select level 1 or 2!");
            }

            GameLogic startGameLogic = new GameLogic();

            startGameLogic.PlayerNextMove();

         //   GameField.PrintFieldBorders();
                       
        }
    }
}
