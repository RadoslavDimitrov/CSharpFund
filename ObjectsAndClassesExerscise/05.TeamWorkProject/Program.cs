using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _05.TeamWorkProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfTeam = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < numOfTeam; i++)
            {
                var currTeamCreaton = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                
                if(teams.Any(x => x.Creator == currTeamCreaton[0]))
                {
                    Console.WriteLine($"{currTeamCreaton[0]} cannot create another team!");
                    continue;
                }
                else if (teams.Any(x => x.TeamName == currTeamCreaton[1]))
                {
                    Console.WriteLine($"Team {currTeamCreaton[1]} was already created!");
                    continue;
                }
                else
                {
                    Team currTeam = new Team(currTeamCreaton[0], currTeamCreaton[1]);
                    teams.Add(currTeam);
                    Console.WriteLine($"Team {currTeamCreaton[1]} has been created by {currTeamCreaton[0]}!");
                }
                
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end of assignment")
            {

                var pplToJoin = command.Split("->", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if(!teams.Any(x => x.TeamName == pplToJoin[1]))
                {
                    Console.WriteLine($"Team {pplToJoin[1]} does not exist!");
                    continue;
                }
                if(teams.Any(x => x.Creator == pplToJoin[0]))
                {
                    Console.WriteLine($"Member {pplToJoin[0]} cannot join team {pplToJoin[1]}!");
                    continue;
                }
                else
                {
                    int index = teams.FindIndex(x => x.TeamName == pplToJoin[1]);
                    if (teams[index].IsInTeam)
                    {

                    }
                    
                    teams[index].PplJoined(pplToJoin[0]);
                }
                

            }


            //user - team / user = creator
            //"Team {teamName} has been created by {user}!".
        }
    }

    public  class Team
    {
        public string Creator { get; set; }

        public string TeamName { get; set; }

        public static List<string> peopleJoined = new List<string>();

        public Team(string creator, string teamName)
        {
            this.Creator = creator;
            this.TeamName = teamName;
        }

        public void PplJoined(string user)
        {
            peopleJoined.Add(user);
        }

        public bool IsInTeam(string name)
        {
            bool isHere = false;
            for (int i = 0; i < peopleJoined.Count; i++)
            {
                if(peopleJoined[i] == "name")
                {
                    isHere = true;
                }
            }

            return isHere;
        }
    }
}
