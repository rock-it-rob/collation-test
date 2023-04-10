using System.ComponentModel.DataAnnotations;

namespace Repository.Model;

public class Person
{
    [Required]
    public string? FirstName { get; set; }

    [Required]
    public string? LastName { get; set; }

    // The active column is not-nullable but there is no need to annotate it required
    // when a default value is specified.
    public bool Active { get; set; } = true;

    public Person()
    {
    }

    public Person(string firstName, string lastName)
        => (FirstName, LastName) = (firstName, lastName);
}