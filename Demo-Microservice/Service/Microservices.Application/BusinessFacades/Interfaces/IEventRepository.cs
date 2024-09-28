using Microservices.Domain.Model;

namespace Microservices.Application.BusinessFacades.Interfaces;

public interface IEventRepository
{
    Task<Event> GetEventByIdAsync(int eventId);
}