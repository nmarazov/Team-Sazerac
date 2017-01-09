using System;
using OOPTeamwork.GameInterfaces;

namespace OOPTeamwork.Core
{
    public class LevelSelection : ILevelSelection
    {
        public int SelectLevel()
        {           
            Console.Write($"Please select 1 for first level or 2 for second level : ");
            var userInput = int.Parse(Console.ReadLine());
         
            return userInput;
        }
    }
}
