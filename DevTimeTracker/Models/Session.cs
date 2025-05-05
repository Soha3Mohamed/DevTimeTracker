using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTimeTracker.Models
{
     public enum SessionType
    {
        Learning,
        ProjectWork,
        Debugging,
        ReadingDocs,
        LightStudy,
        Other
    }
     public class Session
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public SessionType SessionType { get; set; }
        public string ProjectName { get; set; }

        public Session(DateTime _startTime, DateTime _dateTime, string _description, SessionType _sessionType, string _projectName)
        {
            StartTime = _startTime;
            EndTime= _dateTime;
            Description = _description;
            SessionType = _sessionType;
            ProjectName = _projectName;
        }
        public Session()
        {

        }
        public override string ToString()
        {
            string duration = EndTime != default
                ? (EndTime - StartTime).ToString(@"hh\:mm\:ss")
                : "In Progress";

            return $"Session started at: {StartTime}\n" +
                   $"Ended at: {(EndTime == default ? "..." : EndTime)}\n" +
                   $"Duration: {duration}\n" +
                   $"Project: {ProjectName}\n" +
                   $"Session Type: {SessionType}\n" +
                   $"Details: {Description}";
        }

    }

}
