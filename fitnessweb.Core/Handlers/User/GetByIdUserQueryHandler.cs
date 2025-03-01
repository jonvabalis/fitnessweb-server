using fitnessweb.Core.Queries;
using fitnessweb.Infrastructure;
using MediatR;

namespace fitnessweb.Core.Handlers.User;

public class GetByIdUserQueryHandler(FitnessWebDbContext fitnessDbContext) : IRequestHandler<GetByIdUserQuery, Domain.Entities.User>
{
    public async Task<Domain.Entities.User> Handle(GetByIdUserQuery request, CancellationToken cancellationToken)
    {
        return await fitnessDbContext.Users.FindAsync([request.Id], cancellationToken)
               ?? throw new NullReferenceException();
    }
}