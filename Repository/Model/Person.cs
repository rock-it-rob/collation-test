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

    public bool Deleted { get; set; } = false;

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
    }
}