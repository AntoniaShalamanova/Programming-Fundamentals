using System;
using System.Linq;
using System.Collections.Generic;

namespace P9TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < groupsCount; i++)
            {
                string[] input = Console.ReadLine().Split('-').ToArray();

                string creatorName = input[0];
                string teamName = input[1];

                if (teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else
                {
                    if (teams.Any(x => x.Creator == creatorName) || teams.Any(x => x.Members.Contains(creatorName)))
                    {
                        Console.WriteLine($"{creatorName} cannot create another team!");
                    }
                    else
                    {
                        Team team = new Team();
                        team.Name = teamName;
                        team.Creator = creatorName;
                        team.Members = new List<string>();

                        teams.Add(team);

                        Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                    }
                }
            }

            string line = Console.ReadLine();
            
            while (line != "end of assignment")
            {
                string[] input = line.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string joinerName = input[0];
                string teamName = input[1];

                if (!teams.Any(x => x.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(x => x.Creator == joinerName) || teams.Any(x => x.Members.Contains(joinerName)))
                {
                    Console.WriteLine($"Member {joinerName} cannot join team {teamName}!");
                }
                else
                {
                    int teamIndx = teams.FindIndex(x => x.Name == teamName);
                    teams[teamIndx].Members.Add(joinerName);
                }

                line = Console.ReadLine();
            }

            foreach (var team in teams.Where(x => x.Members.Count != 0).OrderByDescending(x => x.Members.Count).ThenBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");

                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in teams.Where(x => x.Members.Count == 0).OrderBy(x => x.Name))
            {
                Console.WriteLine(team.Name);
            }
        }
    }

    class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}