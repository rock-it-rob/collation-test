using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Model;

public class Person
{
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
        entityBuilder
            // Configure the partial index on the name fields where deleted is false.
            .HasIndex(p => new { p.FirstName, p.LastName })
            .IsUnique()
            .HasFilter("active");
    }
}