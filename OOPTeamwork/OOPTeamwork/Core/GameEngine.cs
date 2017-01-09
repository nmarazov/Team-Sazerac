using System;
using OOPTeamwork.GameInterfaces;
using OOPTeamwork.GameStructure.Levels;

namespace OOPTeamwork.GameStructure
{
    public class GameEngine
    {
        private readonly ILevelSelection levelSelection;
        public GameEngine(ILevelFactory levelFactory, IReaderWriterProvider readerWriterProvider, )
        {
            this.levelSelection = levelSelection;
        }

        public void StartGame()
        {
            LevelSelection level = new LevelSelection();

            FirstLevel firstLevel = new FirstLevel();

            this.levelSelection.SelectLevel(); 

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
