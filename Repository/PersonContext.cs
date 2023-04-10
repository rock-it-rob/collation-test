using Microsoft.EntityFrameworkCore;

namespace Repository;

public class PersonContext : DbContext
{
    public PersonContext(DbContextOptions<PersonContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        // Call the entity method on each entity to fire their configuring interfaces.
        builder.ApplyConfigurationsFromAssembly(typeof(PersonContext).Assembly);
    }
}