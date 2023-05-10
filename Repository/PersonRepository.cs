using Repository.Model;

namespace Repository;

public class PersonRepository
{
    public PersonContext Context { get; }

    public PersonRepository(PersonContext context)
        => Context = context;

    public void Create(Person entity) =>
        Context.Add(entity);

    public Person? Read(long id) =>
        Context.Find<Person>(id);

    public void Update(Person entity) =>
        Context.Update(entity);

    public void Delete(Person entity) =>
        Context.Remove(entity);

    public int SaveChanges() =>
        Context.SaveChanges();
}