using System;
using OOPTeamwork.Core.Contracts;

namespace OOPTeamwork.Core.Providers
{
    class ConsoleWriterProvider : IWriter
    {
        public void Write(string message)
        {
            Console.Write(message);
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public void ChangeColor(ConsoleColor color)
        {
            Console.BackgroundColor = color;
        }

        public void Clear()
        {
            Console.Clear();
        }

        public void ResetColor()
        {
            Console.ResetColor();
        }
    }
}
