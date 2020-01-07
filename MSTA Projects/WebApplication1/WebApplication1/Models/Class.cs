using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Event
    {
        public string Title { get; set; }
    }
    public class Jobs
    {
        public string Title { get; set; }

    }
    public class Learning
    {
        public string Title { get; set; }

    }
    class dbContext
    {
        public List<Event> events = new List<Event>();
        public List<Jobs> jobs = new List<Jobs>();
        public List<Learning> learnings = new List<Learning>();
        public dbContext()
        {
            events.Add(new Event() { Title = "First event" });
            events.Add(new Event() { Title = "second event" });
            events.Add(new Event() { Title = "third event" });
            jobs.Add(new Jobs() { Title = "First job" });
            jobs.Add(new Jobs() { Title = "second job" });
            jobs.Add(new Jobs() { Title = "third job" });
            learnings.Add(new Learning() { Title = "First learning" });
            learnings.Add(new Learning() { Title = "second learning" });
            learnings.Add(new Learning() { Title = "third learning" });
        }
    }
    public class HomeIndexViewModel
    {
        public List<Event> events;
        public List<Jobs> jobs;
        public List<Learning> learnings;

    }

}
