using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeamwork.GameStructure
{
    public class GameEngine
    {
        public static void StartGame()
        {
            LevelSelection level = new LevelSelection();

            FirstLevel firstLevel = new FirstLevel();

            var selectedLevel = level.SelectLevel(); 

            if (selectedLevel == (int)(LevelType.one))
            {
                GameField.PrintFieldBorders();
                firstLevel.StartLevel();
            }

            else if (selectedLevel == (int)(LevelType.two))
            {
              
                GameField.PrintFieldBorders();
                //TODO: secondLevel.StartSeconsLevel;
            }

            else
            {
                throw new ArgumentException("Please select level 1 or 2!");
            }
        }       
    }
}
