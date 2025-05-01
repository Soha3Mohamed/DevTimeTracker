using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevTimeTracker.Models;
namespace DevTimeTracker
{
    //so the session store is just the database layer of the app. it has the list of sessions and it is
    //responsible for adding session, saving sessions, and getting them to other parts of the app
    internal class SessionStore
    {
        private List<Session> Sessions = new List<Session>();

        public SessionStore(List<Session> _sessions)
        {
            Sessions = _sessions;
        }

        public void Add(Session session)
        {
            Sessions.Add(session);
        }
        public void Remove(Session session)
        {
            Sessions.Remove(session);
        }
        public List<Session> GetSessions()
        {
            return Sessions;
        }
    }
}
