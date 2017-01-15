using System;
using System.Threading;
using OOPTeamwork.Core.Contracts;
using OOPTeamwork.Core.Exceptions;
using OOPTeamwork.Models.Contracts;

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
            ILevel selectedLevel = null;
            this.writer.WriteLine("Enter Level");
            this.writer.WriteLine("1-Multiplayer");
            this.writer.WriteLine("2-Singleplayer");
            try
            {
                var inputLevel = int.Parse(this.reader.ReadLine());
                selectedLevel = this.levelFactory.GetLevel(inputLevel);
            }
            catch (InvalidLevelSelectException ex)
            {
                this.writer.WriteLine(ex.Message);
                this.StartGame();
            }

            try
            {
                if (selectedLevel != null)
                {
                    selectedLevel.StartLevel();
                }
            }
            catch (Exception ex)
            {
                this.writer.WriteLine(ex.Message);
            }
            finally
            {
                 Result.Instance.PrintResult();
                this.writer.WriteLine("Do you want to clear the results? Y/N");
                var clear = this.reader.ReadLine();
                if(clear.ToLower() == "y")
                {
                    Result.Instance.ClearResult();
                    this.writer.WriteLine("Result is cleared!");
                }

                this.writer.WriteLine("Do you want to play more? Y/N");
                var playMore = this.reader.ReadLine();
                if (playMore.ToLower() == "y")
                {
                    GameField.Instance.ClearGameField();
                    this.StartGame();
                }
                else if (playMore.ToLower() == "n")
                {
                    this.writer.WriteLine(Result.Instance.PrintResult());
                    Thread.Sleep(2000);
                    Environment.Exit(0);
                }
            }
        }
    }
}
