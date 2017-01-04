using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeamwork
{
    public interface IPlayer
    {
        int Choice { get; set; }

        void Play();

         char PlayerSymbol { get; set; }
    }
}
