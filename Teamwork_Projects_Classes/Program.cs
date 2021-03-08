namespace Teamwork_Projects_Classes
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            List<TeamworkProjects> team = new List<TeamworkProjects>();

            int countTeam = int.Parse(Console.ReadLine());

            for (int i = 0; i < countTeam; i++)
            {
                string[] createTeam = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);

                string teamName = createTeam[1];
                string userCreator = createTeam[0];

                team.Add(new TeamworkProjects()
                {
                    TeamName = teamName,
                    UserCreator = userCreator
                });

                foreach (TeamworkProjects item in team)
                {
                    if (item.UserCreator.Contains(userCreator))
                    {
                        Console.WriteLine($"Team {teamName} has been created by {userCreator}!");
                        break;
                    }
                    else
                    {
                        if (!item.TeamName.Contains(teamName))
                        {
                            Console.WriteLine($"Team {teamName} has been created by {userCreator}!");
                            break;
                        }
                        Console.WriteLine($"Team {teamName} was already created!");
                        break;
                    }
                }
            }

            while (true)
            {
                string[] joinTeam = Console.ReadLine()
                        .Split("->", StringSplitOptions.RemoveEmptyEntries);

                string member = joinTeam[0];

                if (member == "end of assignment")
                    break;

                string joinTeam2 = joinTeam[1];

             //   List<string> members = new List<string>();
             //   members = team.

                foreach (TeamworkProjects members1 in team)
                {
                    if (members1.Member.Contains(members1.TeamName))
                    {
                        Console.WriteLine($"Member {member} cannot join team {joinTeam2}!");
                    }
                }
            }
        }
    }
}
