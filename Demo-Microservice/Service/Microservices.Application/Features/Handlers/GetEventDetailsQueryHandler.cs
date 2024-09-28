using MediatR;
using Microservices.Application.BusinessFacades.Interfaces;
using Microservices.Application.Features.Queries;
using Microservices.Domain.Model;

namespace Microservices.Application.Features.Handlers;

public class GetEventDetailsQueryHandler  
    : IRequestHandler<GetEventDetailsQuery, Event>
{
    private readonly IEventRepository _repository;

    public GetEventDetailsQueryHandler(IEventRepository repository)
    {
        _repository = repository;
    }

    public async Task<Event> Handle(GetEventDetailsQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetEventByIdAsync(request.Id);
    }
}