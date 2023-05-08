namespace Repository.Test;

public abstract class AbstractTest
{
    protected readonly PersonRepository _personRepository;

    protected IRepository<Person, long> Repository
        => (IRepository<Person, long>)_personRepository;

    public AbstractTest()
        => _personRepository = new PersonRepository(new PersonContext());
}