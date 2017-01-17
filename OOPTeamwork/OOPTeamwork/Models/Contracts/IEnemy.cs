using System.Collections.Generic;

namespace OOPTeamwork.Models.Contracts
{
    public interface IEnemy
    {
        ICollection<int> ComputerMoves { get; }

        int Position { get; }
    }
}
