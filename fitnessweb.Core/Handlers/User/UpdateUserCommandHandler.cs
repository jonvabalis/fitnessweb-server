using fitnessweb.Core.Commands;
using fitnessweb.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace fitnessweb.Core.Handlers.User;

public class UpdateUserCommandHandler(FitnessWebDbContext fitnessDbContext) : IRequestHandler<UpdateUserCommand, Unit>
{
    public async Task<Unit> Handle(UpdateUserCommand command, CancellationToken cancellationToken)
    {
        var user = await fitnessDbContext.Users.FindAsync([command.UserId], cancellationToken);
        
        if (user == null)
            throw new Exception($"User with ID {command.UserId} not found");
        
        if (command.FirstName != null)
            user.FirstName = command.FirstName;
            
        if (command.LastName != null)
            user.LastName = command.LastName;
            
        if (command.Email != null)
            user.Email = command.Email;
            
        if (command.Password != null)
            user.Password = command.Password;
            
        if (command.PhoneNumber != null)
            user.PhoneNumber = command.PhoneNumber;
            
        if (command.Birthday.HasValue)
            user.Birthday = command.Birthday.Value;

        await fitnessDbContext.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}