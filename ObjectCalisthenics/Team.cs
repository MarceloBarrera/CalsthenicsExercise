using System.Collections.Generic;
using System.Linq;

namespace ObjectCalisthenics
{
    class Team
    {
      
        private List<Player> MalePlayers;
        private List<Player> FemalePlayers;
 
        private int TotalMembers()
        {
            return MalePlayers.Count + FemalePlayers.Count;
        }

        public Team(List<Player> malePlayers, List<Player> femalePlayers)
        {
            MalePlayers = malePlayers;
            FemalePlayers = femalePlayers;
        }
        
        internal bool TotalTeamMembersAreValid()
        {
            if (TotalMembers() < 7)
                return false;
            if (TotalMembers() > 10)
                return false;
            return true;
        }

        internal bool MixTeamMembersAreValid()
        {
            if (MalePlayers.Count < 2)
                return false;
            if (FemalePlayers.Count < 2)
                return false;
            return true;
        }

        internal bool HasAnyPlayerFrom(Team team2)
        {
            foreach (var femalePlayer in FemalePlayers)
            {
                if (team2.ContainsFemalePlayer(femalePlayer))
                    return true;
               
            }
            foreach (var malePlayer in MalePlayers)
            {
                if (team2.ContainsMalePlayer(malePlayer))
                    return true;
            }
            return false;
        }

        private bool ContainsMalePlayer(Player malePlayer)
        {
            if (MalePlayers.Any(p => p.Name == malePlayer.Name))
                return true;
            return false;
        }

        private bool ContainsFemalePlayer(Player femalePlayer)
        {
            if (FemalePlayers.Any(p => p.Name == femalePlayer.Name))
                return true;
            return false;
        }
    }
}
