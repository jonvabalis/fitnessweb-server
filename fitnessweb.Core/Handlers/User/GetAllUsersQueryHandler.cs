using fitnessweb.Core.Queries;
using fitnessweb.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace fitnessweb.Core.Handlers.User;

public class GetAllUsersQueryHandler(FitnessWebDbContext fitnessDbContext) : IRequestHandler<GetAllUsersQuery, List<Domain.Entities.User>>
{
    public async Task<List<Domain.Entities.User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
    {
        return await fitnessDbContext.Users.ToListAsync(cancellationToken);
    }
}