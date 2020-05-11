using System;
using System.Collections.Generic;
using System.Linq;
using TeamSource.Enteties;
using TeamSource.Helpers;

namespace GameCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = TeamsDataBase.GetAllTeams();

            #region Class 13 LINQ

            // Find all TEAMS with names starting with LA
            var teamsStartingWithLA = teams.Where(team => team.Name.StartsWith("LA")).ToList();
            //teamsStartingWithLA.ForEach(team => Console.WriteLine(team.Name));


            // Find all team NAMES which are playing in "Staples Center"
            var teamsPlayingInStaplesCenter = teams.Where(team => team.Arena.Equals("Staples Center"))
                                                      .Select(team => team.Name).ToList();
            //teamsPlayingInStaplesCenter.ForEach(team => Console.WriteLine(team));



            // Find all teams coaches
            var allCoaches = teams.Select(team => team.Coach).ToList();
            //allCoaches.ForEach(coach => Console.WriteLine(coach.FullName));



            // Find 3 oldest coaches NAMES
            var oldest3CoahcesNames = allCoaches.OrderByDescending(coach => coach.Age)
                                                          .Take(3)
                                                            .Select(coach => coach.FullName)
                                                              .ToList();
            //oldest3CoahcesNames.ForEach(trainerName => Console.WriteLine(trainerName));



            // Group all teams by their arenas
            var groupedTeamsByArenas = teams.GroupBy(team => team.Arena).ToList();
            //foreach (var group in groupedTeamsByArenas)
            //{
            //    Console.WriteLine($"{group.Key}");
            //    foreach (var team in group)
            //    {
            //        Console.WriteLine($"-------------{team.Name}");
            //    }
            //}


            // Find all players in one LIST
            var allPlayers = new List<Player>();
            teams.ForEach(team => allPlayers.AddRange(team.Players));
            //allPlayers.ForEach(player => Console.WriteLine(player.FullName));

            //Find player with best avgPtsPerGame
            var playerWithMostPtsPerGame = allPlayers.OrderByDescending(player => player.PlayerStatistic["PtsPerGame"])
                                                          .FirstOrDefault();
            //Console.WriteLine(playerWithMostPtsPerGame.FullName);

            #endregion

            #region HOMEWORK Class 13 LINQ

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            // Find all coaches NAMES with Age > 50

            var allCoachesOver50 = teams.Where(team => team.Coach.Age > 50).Select(team => team.Coach.FullName).ToList();
            //allCoachesOver50.ForEach(coach => Console.WriteLine(coach));


            // Order players by AGE - DESC

            var allPlayers2 = new List<Player>();
            teams.ForEach(team => allPlayers2.AddRange(team.Players));
            var PlayersByAgeDESC = allPlayers2.OrderByDescending(player => player.Age).ToList();
            //PlayersByAgeDESC.ForEach(player => Console.WriteLine(player.FullName));


            // Find player with highest RebPerGame

            var highestRebPerGame = allPlayers2.OrderBy(player => player.PlayerStatistic["RebPerGame"]).LastOrDefault();
            //Console.WriteLine(highestRebPerGame.FullName);

            // Find all players with PtsPerGame > 20

            var PlayersOver20pts = allPlayers2.Where(player => player.PlayerStatistic["PtsPerGame"] > 20.0f)
                                                .ToList();
            //PlayersOver20pts.ForEach(player => Console.WriteLine(player.FullName));

            // Find all players NAMES older then 30 years

            var PlayersOver30Years = allPlayers2.Where(player => player.Age > 30).Select(plyer => plyer.FullName).ToList();
            //PlayersOver30Years.ForEach(player => Console.WriteLine(player));

            // Group players by age

            var GroupOfPlayers = allPlayers2.GroupBy(player => player.Age).ToList();

            //foreach (var AgeOfPlayer in GroupOfPlayers)
            //{
            //    Console.WriteLine(AgeOfPlayer.Key);

            //    foreach (var player in AgeOfPlayer)
            //    {
            //        Console.WriteLine($"------------{player.FullName}");
            //    }

            //    Console.WriteLine("__________________________________");
            //}

            // Find All players NAMES and PtsPerGame if have RebPerGame > 7.0

            var playersOver7Reb = allPlayers2.Where(player => player.PlayerStatistic["RebPerGame"] > 7.0f)
                                                 .Select(player => new {Name = player.FullName, Points = player.PlayerStatistic["PtsPerGame"]})
                                                    .ToList();
            //playersOver7Reb.ForEach(anonymous => Console.WriteLine(anonymous));


            // Find first 3 players with highest PtsPerGame

            var threePHighestPtsPerGame = allPlayers2.OrderByDescending(player => player.PlayerStatistic["PtsPerGame"])
                                                        .Take(3).ToList();
            //threePHighestPtsPerGame.ForEach(player => Console.WriteLine(player.FullName));

            // Find the team which has the player with highest PtsPerGame

            var playerWithHighestPPG = allPlayers2.OrderByDescending(player => player.PlayerStatistic["PtsPerGame"])
                                                    .FirstOrDefault();


            var teamOfTheBestPlayer = teams.SingleOrDefault(team => team.Players.Contains(playerWithHighestPPG));

            //Console.WriteLine(teamOfTheBestPlayer.Name);

            // Find first 4 players with highest RebPerGame and order them by PtsPerGame - ASC

            var fourPhighestRebPerGame = allPlayers2.OrderBy(player => player.PlayerStatistic["RebPerGame"])
                                                        .TakeLast(4).OrderBy(player => player.PlayerStatistic["PtsPerGame"])
                                                            .ToList();
            //fourPhighestRebPerGame.ForEach(player => Console.WriteLine(player.FullName));


            #endregion

            Console.ReadLine();
        }
    }
}
