namespace Microservices.Domain.Model;

public class Registration
{
    public Guid RegistrationId { get; set; }
    public Guid EventId { get; set; }
    public string UserName { get; set; }
    public DateTime RegisteredAt { get; set; }
}