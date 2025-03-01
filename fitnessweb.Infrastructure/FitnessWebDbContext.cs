using fitnessweb.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace fitnessweb.Infrastructure;

public class FitnessWebDbContext(DbContextOptions<FitnessWebDbContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
}