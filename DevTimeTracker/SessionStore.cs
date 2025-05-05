using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevTimeTracker.Models;
using System.Text.Json;
namespace DevTimeTracker
{
    //so the session store is just the database layer of the app. it has the list of sessions and it is
    //responsible for adding session, saving sessions, and getting them to other parts of the app
    public class SessionStore
    {
        private const string filePath = "sessions.json";
        private List<Session> sessions = new(); // -> syntactic sugar introduced in c# 9.0 to improve readability( as long as the type is declared at first not var because that is not allowed
        //private List<Session> Sessions = new List<Session>();

        public SessionStore()
        {
            sessions = LoadFromFile();
            
        }
        public void Add(Session session)
        {
            sessions.Add(session);
            SaveToFile();
        }
        public void Remove(Session session)
        {
            sessions.Remove(session);
            SaveToFile();
        }
        public List<Session> GetSessions()
        {
            return sessions;
        }
        public void SaveToFile()
        {
            try
            {
                string json = JsonSerializer.Serialize(sessions);
                File.WriteAllText(filePath, json);
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"Error Saving Data : {ex.Message}");
            }
          
        }

        public List<Session> LoadFromFile()
        { 
            if (!File.Exists(filePath))
            {
                return new List<Session>(); //return empty string if file doesn't exist or if nothing is saved yet
            }
            try
            {
                string json = File.ReadAllText(filePath);
                List<Session> sessions = JsonSerializer.Deserialize<List<Session>>(json) ?? new List<Session>();
                return sessions;
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"Error Loading Data : {ex.Message}");
                return new List<Session>();
            }
            
        }
    }
}
