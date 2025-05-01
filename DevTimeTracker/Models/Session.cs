using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTimeTracker.Models
{
     enum SessionType
    {
        Learning,
        ProjectWork,
        Debugging,
        ReadingDocs,
        LightStudy,
        Other
    }
     class Session
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
            //return base.ToString(); // this would give you namespace.className
            return $"Session started at: {StartTime}\nEnded at: {EndTime}\n" +
                   $"Project: {ProjectName}\nSession Type: {SessionType}\nDetails: {Description}";
        }
    }

}
