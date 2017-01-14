using OOPTeamwork.Core;
using OOPTeamwork.Core.Contracts;

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
            this.writer.WriteLine("Enter Level");
            this.writer.WriteLine("1-Multiplayer");
            this.writer.WriteLine("2-Singleplayer");
            var inputLevel = int.Parse(this.reader.ReadLine());
            var selectedLevel = this.levelFactory.GetLevel(inputLevel);
            
            selectedLevel.StartLevel();
        }

        public void AnotherGame()
        {
            this.writer.WriteLine("Do you want to start another game?\n1 - Yes. let's go!\n2- No, I had enough!");
            var choice = int.Parse(this.reader.ReadLine());
            System.Console.Clear();
            switch (choice)
            {
                case 1:
                    GameField.GameFieldClear();
                    var levelFactory = new LevelFactory();
                    var engine = new GameEngine(levelFactory, reader, writer);
                    StartGame();
                    AnotherGame();
                    break;
                case 2:
                    this.writer.WriteLine("See you next time!");
                    break;
                default:
                    this.writer.WriteLine("You must choose between \"1\" and \"2\"!");
                    AnotherGame();
                    break;
            }
        }
    }
}
