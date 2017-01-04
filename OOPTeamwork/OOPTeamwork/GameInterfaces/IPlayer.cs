using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeamwork
{
    public interface IPlayer
    {
        // int Choice { get; set; }
        int PlayerIndex { get; }

        void PlayerNextMove();

     //    char PlayerSymbol { get; set; }
    }
}
