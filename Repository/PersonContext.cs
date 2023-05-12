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
        // Create a system-wide collation for case-insensitive matching
        // with a UCA strength of primary.
        builder.HasCollation(Collations.UcaStrengthPrimaryCollation);

        // Call the entity method on each entity to fire their configuring interfaces.
        builder.ApplyConfigurationsFromAssembly(typeof(PersonContext).Assembly);
    }
}