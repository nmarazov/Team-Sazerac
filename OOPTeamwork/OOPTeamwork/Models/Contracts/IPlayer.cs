namespace OOPTeamwork.Models.Contracts
{
    public interface IPlayer
    {
        // int Choice { get; set; }
        int PlayerIndex { get; }

        void PlayerNextMove();

     // char PlayerSymbol { get; set; }
    }
}
