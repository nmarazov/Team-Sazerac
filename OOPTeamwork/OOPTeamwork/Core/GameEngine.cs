using System;
using OOPTeamwork.Core.Contracts;
using OOPTeamwork.Models.Enums;
using OOPTeamwork.Models.Levels;

namespace OOPTeamwork.Core
{
    public class GameEngine
    {
        private readonly ILevelFactory levelFactory;
        private readonly IReader reader;
        private readonly IWriter writer;

        public GameEngine(ILevelFactory levelFactory, IReader reader, IWriter writer)
        {
            this.levelFactory = levelFactory;
            this.reader = reader;
            this.writer = writer;
        }

        public void StartGame()
        {
            writer.WriteLine("Enter Level");
            var inputLevel = reader.ReadLine();
            var selectedLevel = levelFactory.GetLevel(inputLevel);
            
            GameField.PrintFieldBorders();
            selectedLevel.StartLevel();
        }       
    }
}
