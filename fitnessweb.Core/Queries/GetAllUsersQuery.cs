using fitnessweb.Domain.Entities;
using MediatR;

namespace fitnessweb.Core.Queries;

public class GetAllUsersQuery : IRequest<List<User>>;