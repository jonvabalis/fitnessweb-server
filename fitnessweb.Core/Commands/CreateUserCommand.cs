using MediatR;

namespace fitnessweb.Core.Commands;

public class CreateUserCommand : IRequest<Unit>
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }
    public required string PhoneNumber { get; set; }
    public required DateTime Birthday { get; set; }
}