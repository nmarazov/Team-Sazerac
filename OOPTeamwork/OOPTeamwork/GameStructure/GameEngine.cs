using System;

using OOPTeamwork.GameStructure.Levels;

namespace OOPTeamwork.GameStructure
{
    public class GameEngine
    {
        public static void StartGame()
        {
            LevelSelection level = new LevelSelection();

            FirstLevel firstLevel = new FirstLevel();

            var selectedLevel = level.SelectLevel(); 

            if (selectedLevel == (int)LevelType.Оne)
            {
                GameField.PrintFieldBorders();
                firstLevel.StartLevel();
            }
            else if (selectedLevel == (int)LevelType.Тwo)
            {
                // TODO: secondLevel.StartSeconsLevel;
                GameField.PrintFieldBorders();
            }
            else
            {
                throw new ArgumentException("Please select level 1 or 2!");
            }
        }       
    }
}
