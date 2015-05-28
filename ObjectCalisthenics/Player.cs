using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectCalisthenics
{
    class Player
    {
        public string Name;
        public char Gender;
        private int TotalSuspensionGames;
        public Player(string name, char gender)
        {
            Name = name;
            Gender = gender;
        }

        public void UpdateSuspensionGames(int totalSuspensionGames)
        {
            TotalSuspensionGames = totalSuspensionGames;
        }
    }
}
