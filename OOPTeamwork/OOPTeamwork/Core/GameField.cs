using System.Text;
using OOPTeamwork.Core.Contracts;

namespace OOPTeamwork.Core
{
    public class GameField : IGameField
    {
        private static GameField instance;

        private char[] inputSelection;

        private GameField()
        {
            this.inputSelection = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        }

        public static GameField Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameField();
                }

                return instance;
            }
        }

        public char[] InputSelection
        {
            get
            {
                return this.inputSelection;
            }

            private set
            {
                this.inputSelection = value;
            }
        }
        
        public string PrintGameField()
        {
            var result = new StringBuilder();
            
            result.AppendLine("     |     |      ");
            result.AppendLine($"  {InputSelection[6]}  |  {InputSelection[7]}  |  {InputSelection[8]}");
            result.AppendLine("_____|_____|_____ ");
            result.AppendLine("     |     |      ");
            result.AppendLine($"  {InputSelection[3]}  |  {InputSelection[4]}  |  {InputSelection[5]}");
            result.AppendLine("_____|_____|_____ ");
            result.AppendLine("     |     |      ");
            result.AppendLine($"  {InputSelection[0]}  |  {InputSelection[1]}  |  {InputSelection[2]}");
            result.AppendLine("     |     |      ");
            result.AppendLine();
            return result.ToString();
        }
    }
}
