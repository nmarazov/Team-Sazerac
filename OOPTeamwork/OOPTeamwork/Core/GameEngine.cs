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
    }
}
