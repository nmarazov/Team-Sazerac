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
            Console.Write($"Please select a level 1 or 2 : ");
            var userInput = int.Parse(Console.ReadLine());
         
            return userInput;
        }
    }
}
