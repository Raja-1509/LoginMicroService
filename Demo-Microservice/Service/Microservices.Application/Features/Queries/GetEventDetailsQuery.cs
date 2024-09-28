using MediatR;
using Microservices.Domain.Model;

namespace Microservices.Application.Features.Queries
{
    public class GetEventDetailsQuery : IRequest<Event>
    {
        public int Id { get; }

        public GetEventDetailsQuery(int id)
        {
            Id = id;
        }
    }
}