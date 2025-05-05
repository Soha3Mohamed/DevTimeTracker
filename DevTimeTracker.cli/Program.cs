using DevTimeTracker.Models;
using System;

namespace DevTimeTracker.cli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SessionStore store = new SessionStore();
            SessionManager manager = new SessionManager(store);

            while (true)
            {
                Console.WriteLine("\n--- Dev Time Tracker ---");
                Console.WriteLine("1. Start session");
                Console.WriteLine("2. End session");
                Console.WriteLine("3. Show current session");
                Console.WriteLine("4. Get all sessions");
                Console.WriteLine("5. Filter by project name");
                Console.WriteLine("6. Filter by session type");
                Console.WriteLine("7. Get All Hours Spent On Project");
                Console.WriteLine("8. Get All Project Names");
                Console.WriteLine("0. Exit");
                Console.Write("Choose an option: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Project name: ");
                        string projectName = Console.ReadLine();

                        Console.Write("Description: ");
                        string description = Console.ReadLine();

                        Console.Write("Session Type (0 = Deep Work, 1 = Light Work): ");
                        SessionType type = (SessionType)int.Parse(Console.ReadLine());

                        manager.StartSession(DateTime.Now, description, projectName, type);
                        break;

                    case "2":
                        manager.EndSession();
                        break;

                    case "3":
                        var current = manager.ShowCurrentSession();
                        Console.WriteLine(current?.ToString() ?? "No session running.");
                        break;

                    case "4":
                        var sessions = store.GetSessions();
                        foreach (var session in sessions)
                            Console.WriteLine(session);
                        break;

                    case "5":
                        Console.Write("Project name: ");
                        string proj = Console.ReadLine();
                        var filteredByProject = manager.FilterSessionsByProjectName(proj);
                        foreach (var session in filteredByProject)
                            Console.WriteLine(session);
                        break;

                    case "6":
                        Console.Write("Session Type (0 = Learning, 1 = ProjectWork, 2 = Debugging Work, 3 = ReadingDocs, 4 = LightStudy, 5 = Other ");
        
                        SessionType sType = (SessionType)int.Parse(Console.ReadLine());
                        var filteredByType = manager.FilterSessionsBySessionType(sType);
                        foreach (var session in filteredByType)
                            Console.WriteLine(session);
                        break;
                    case "7":
                        Console.Write("Project name: ");
                        proj = Console.ReadLine();
                        var HoursOfProject = manager.GetAllHoursSpentOnProject(proj);
                            Console.WriteLine(HoursOfProject);
                        break;//GetAllProjectNames
                    case "8":
                        var projectNames = manager.GetAllProjectNames();
                        foreach (var name in projectNames)
                            Console.WriteLine(name);
                        break;
                    case "0":
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
    }
}
