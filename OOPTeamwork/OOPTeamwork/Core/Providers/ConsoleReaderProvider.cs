using System;
using OOPTeamwork.Core.Contracts;

namespace OOPTeamwork.Core.Providers
{
    public class ConsoleReaderProvider : IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
