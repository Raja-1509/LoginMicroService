namespace Microservices.Domain.Model;

public class Event
{
    public int EventId { get; set; }
    public string Name { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; }
    public List<Registration> Registrations { get; set; } = new List<Registration>();
}