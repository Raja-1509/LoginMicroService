using Microservices.Application.BusinessFacades.Interfaces;
using Microservices.Domain.Model;

namespace Microservices.Infrastructure.Implementations;

public class EventRepository : IEventRepository
{
    public Task<Event> GetEventByIdAsync(int id)
    {
        var output = new Event();
        output.Name = "Test";
        return Task.FromResult(output);
    }
}