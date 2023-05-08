using Repository.Model;
using Microsoft.EntityFrameworkCore;

namespace Repository;

public class PersonContext : DbContext
{
    public DbSet<Person> Person => Set<Person>();

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        var host = "localhost";
        var username = "pi-user";
        var password = "pi-password";

        builder
            .UseNpgsql($"Host={host};Username={username};Password={password}")
            .UseSnakeCaseNamingConvention();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        // Call the entity method on each entity to fire their configuring interfaces.
        builder.ApplyConfigurationsFromAssembly(typeof(PersonContext).Assembly);
    }
}