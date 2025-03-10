using MediatR;

namespace fitnessweb.Core.Commands;

public class UpdateUserCommand : IRequest<Unit>
{
    public Guid UserId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public string? PhoneNumber { get; set; }
    public DateTime? Birthday { get; set; }
}