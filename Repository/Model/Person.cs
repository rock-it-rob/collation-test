using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Model;

public class Person
{
    public static readonly string NAME_INDEX_UNIQUE = "person_names_unq";

    [Key]
    public long Id { get; set; }

    [Required]
    public string? FirstName { get; set; }

    [Required]
    public string? LastName { get; set; }

    public bool Active { get; set; } = true;

    public Person()
    {
    }

    public Person(string firstName, string lastName)
        => (FirstName, LastName) = (firstName, lastName);
}

public class PersonConfiguration : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> entityBuilder)
    {
        // Set the collation type on the name fields to be case-insensitive.
        entityBuilder
            .Property(p => p.FirstName)
            .UseCollation(UcaStrengthPrimaryCollation.INSTANCE.Name);
        entityBuilder
            .Property(p => p.LastName)
            .UseCollation(UcaStrengthPrimaryCollation.INSTANCE.Name);

        // Configure the partial index on the name fields where deleted is false.
        entityBuilder
            .HasIndex(p => new { p.FirstName, p.LastName })
            .HasDatabaseName(Person.NAME_INDEX_UNIQUE)
            .IsUnique()
            .HasFilter("active");
    }
}