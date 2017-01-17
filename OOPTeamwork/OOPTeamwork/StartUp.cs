using OOPTeamwork.Core;
using OOPTeamwork.Core.Providers;

namespace OOPTeamwork
{
    public class StartUp
    {
        public static void Main()
        {
 
            var reader = new ConsoleReaderProvider();
            var writer = new ConsoleWriterProvider();
            var levelFactory = new LevelFactory();
            var gameBoard = new GameBoardProvider();
            gameBoard.Caption = "TicTacTop";
            gameBoard.Form.ShowDialog();

            var engine = new GameEngine(levelFactory, reader, writer, gameBoard);

            engine.StartGame();                      
        }
    }
}
