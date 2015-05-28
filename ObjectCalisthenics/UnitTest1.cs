using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ObjectCalisthenics
{
    [TestClass]
    public class UnitTest1
    {
        private Team team;

        [TestInitialize]
        public void Setup()
        {
            var totalMaleMemebers = 4;
            var totalFemaleMemebers = 3;

            List<Player> malePlayers1 = TestBuilder.CreateMalePlayers(totalMaleMemebers, "Spain");
            List<Player> femalePlayers1 = TestBuilder.CreateFemalePlayers(totalMaleMemebers, "Spain");
            team = new Team(malePlayers1, femalePlayers1);
        }

        [TestMethod]
        public void AsCaptain_WhenCreatingTeam_TotalTeamMembersAreValid()
        {
            bool isValid = team.TotalTeamMembersAreValid();
            Assert.IsTrue(isValid,"total members not within range");
        }

        [TestMethod]
        public void AsCaptain_WhenCreatingTeam_MixMembersAreValid()
        {
            bool isValid = team.MixTeamMembersAreValid();
            Assert.IsTrue(isValid, "total members not mix");
        }

        [TestMethod]
        public void AsCaptain_WhenCreatingTeam_APlayerMustNotExistsInOtherTeam()
        {
            var totalMaleMemebers = 4;
            var totalFemaleMemebers = 3;

            List<Player> malePlayers1 = TestBuilder.CreateMalePlayers(totalMaleMemebers,"Spain");
            List<Player> femalePlayers1 = TestBuilder.CreateFemalePlayers(totalMaleMemebers,"Spain");

            List<Player> malePlayers2 = TestBuilder.CreateMalePlayers(totalMaleMemebers,"UK");
            List<Player> femalePlayers2 = TestBuilder.CreateFemalePlayers(totalMaleMemebers,"UK");

            Team team1 = new Team(malePlayers1, femalePlayers1);
            Team team2 = new Team(malePlayers2, femalePlayers2);

            bool isValid = team1.HasAnyPlayerFrom(team2);
            Assert.IsFalse(isValid, "player exists in team 2");
        }


    }

    public static class TestBuilder
    {

        internal static List<Player> CreateMalePlayers(int totalMaleMemebers, string country)
        {

            var lisMalePlayers = new List<Player>(totalMaleMemebers);
            for (int i = 0; i < totalMaleMemebers; i++)
            {
                Player player = new Player("Javier" + i + country, 'M');
                lisMalePlayers.Add(player);
            }
            return lisMalePlayers;
        }

        internal static List<Player> CreateFemalePlayers(int totFemaleMembers, string country)
        {
            var lisMalePlayers = new List<Player>(totFemaleMembers);
            for (int i = 0; i < totFemaleMembers; i++)
            {
                Player player = new Player("Maria" + i + country, 'F');
                lisMalePlayers.Add(player);
            }
            return lisMalePlayers;
        }
    }
}
