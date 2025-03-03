using fitnessweb.Core.Commands;
using fitnessweb.Infrastructure;
using MediatR;

namespace fitnessweb.Core.Handlers.User;

public class CreateUserCommandHandler(FitnessWebDbContext fitnessDbContext) : IRequestHandler<CreateUserCommand, Unit>
{
    public async Task<Unit> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        var user = new Domain.Entities.User
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber,
            Birthday = request.Birthday,
        };

        await fitnessDbContext.Users.AddAsync(user, cancellationToken);
        await fitnessDbContext.SaveChangesAsync(cancellationToken);
        
        return Unit.Value;
    }
}