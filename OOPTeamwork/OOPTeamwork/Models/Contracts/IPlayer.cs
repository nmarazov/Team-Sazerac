namespace OOPTeamwork.Models.Contracts
{
    public interface IPlayer
    {
        
        int PlayerIndex { get; }

        char PlayerSymbol { get; }

        void PlayerNextMove();

    }
}
