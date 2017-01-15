namespace OOPTeamwork.Models.Contracts
{
    public interface ILevel
    {
        void PrintGameField(string gameField);

        void CheckWhoIsTheWinner(int flag, int player);

        void StartLevel();
    }
}
