using OOPTeamwork.GameInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPTeamwork.GameStructure
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
