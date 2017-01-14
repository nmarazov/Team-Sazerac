using System;
using OOPTeamwork.Core.Contracts;
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
            catch (Exception ex)
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
                this.writer.WriteLine("Do you want to play more? Y/N");
                var playMore = this.reader.ReadLine();
                if (playMore.ToLower() == "y")
                {
                    GameField.Instance.ClearGameField();
                    this.StartGame();
                }
            }
            
        }
    }
}