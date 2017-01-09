using System.Text;
using OOPTeamwork.Core.Contracts;

namespace OOPTeamwork.Core
{
    public class GameField : IGameField
    {

        // array on ints - the numbers indicate the position of the current player
        public static char[] InputSelection = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

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
