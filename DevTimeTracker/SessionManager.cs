using DevTimeTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTimeTracker
{
    //the session Manager is the business logic of the app. it is the one responsible for all operations on sessions like:
    //starting a session, ending it ,validating inputs, and making sure no two sessions are running at the same time,...
    internal class SessionManager
    {
        
        private readonly SessionStore _store;
        Session currentSession = null;
        public SessionManager(SessionStore sessionStore)
        {
                _store = sessionStore;
        }
        
        //public void AddSession(DateTime _startTime, DateTime _endTime,string _description,string _projectName,SessionType _sessionType)
        //{
        //    if (currentSession != null)
        //    {
        //        Console.WriteLine("A session is already in progress.");
        //        //in console app make the user chhose either he wants to end this session or not(should return info about that session or not??
        //        return;
        //    }

        //    currentSession = new Session(_startTime,_endTime,_description,_sessionType,_projectName);
        //    _store.Add(currentSession);
        //    currentSession = null;
        //}


        public void StartSession(DateTime _startTime, string _description, string _projectName, SessionType _sessionType)
        {
            if (currentSession != null)
            {
                Console.WriteLine("A session is already in progress.");
                //in console app make the user chhose either he wants to end this session or not(should return info about that session or not??
                return;
            }
            currentSession = new Session
            {
                StartTime = DateTime.Now,
                Description = _description,
                ProjectName = _projectName,
                SessionType = _sessionType
            };
        }
        public void EndSession()
        {
            if(currentSession == null)
            {
                Console.WriteLine("No active session to end.");
                return;
            }

           // Session session = new Session();
            currentSession.EndTime = DateTime.Now;
            _store.Add(currentSession);
            currentSession = null;
        }

        public void RemoveSession(DateTime _startTime,  string _projectName, SessionType _sessionType)
        {
            //i thought that a user may enter the name of the project he wants to remove a session about and when we get all sessions related to project, he chooses 
            //the session he wants to remove??

        }

        public List<Session> FilterSessionsByProjectName(string _projectName)
        {
           //should i keep project names in  list so that i can do operations like preventing duplicates or something??

            return _store.GetSessions().Where(S => S.ProjectName == _projectName).ToList();

        }
        public List<Session> FilterSessionsBySessionType(SessionType _sessionTyepe)
        {
            return _store.GetSessions().Where(S=> S.SessionType == _sessionTyepe).ToList();
            
        }
        public TimeSpan CalculateDurationForSession(Session session)
        {
            return session.EndTime - session.StartTime;
        }

        public TimeSpan GetAllHoursSpentOnProject(string projectName)
        {
            var sessions = _store.GetSessions().Where(S => S.ProjectName == projectName).ToList();
            TimeSpan totalDurations = TimeSpan.Zero;
            foreach(var session in sessions)
            {
                totalDurations += session.EndTime- session.StartTime;
            }
            return totalDurations;
            //return $"Total time spent on '{projectName}': {totalDuration.TotalHours:F2} hours";
        }

        public void CreateAlarm(DateTime _startTime, string _description, string _projectName, SessionType _sessionType, int noOfHours)
        {
           // TimeSpan duration = _startTime.AddHours(2)-;
           currentSession.EndTime = DateTime.Now;
            if(currentSession.EndTime == _startTime.AddHours(noOfHours))
            {
                Console.WriteLine($"you completed the {noOfHours} hours you promised to finish, congratulations");
                currentSession = new Session
                {
                    StartTime = DateTime.Now,
                    Description = _description,
                    ProjectName = _projectName,
                    SessionType = _sessionType
                };
                currentSession = null;

            }
           
        }

        public Session? ShowCurrentSession()
        {
            //i was confused here because the right return type was session but what if i don't have a current one???  %%%%%%%%%%%%%%%%%%%%%%%%%%
            //i will let the user(console app) manages null checking
            //if(currentSession == null)
            //{
            //    return $"there is no active session now";
            //}
            return currentSession;
        }
    }
}
    