namespace CodingEvents.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set;  }
        public int Id { get; }
        private static int nextId = 1;

        public Event()
        {
            Name = "(undefined)";
            Description = "(undefined)";
            Id = nextId;
            nextId++;
        }

        public Event(string name, string description) : base()
        {
            Name = name;
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
