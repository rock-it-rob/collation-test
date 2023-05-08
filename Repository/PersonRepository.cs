using Repository.Model;

namespace Repository;

public class PersonRepository : IRepository<Person, long>
{
    public PersonContext Context { get; }

    public PersonRepository(PersonContext context)
        => Context = context;
}