namespace Repository.Test;

public class PersonTest : AbstractTest
{
    [Test]
    public void createPerson()
    {
        using var _ = Repository.Context.Database.BeginTransaction();

        var person = new Person { FirstName = "First", LastName = " Last" };
        Repository.Create(person);
        Repository.SaveChanges();

        var found = Repository.Context
            .Person
            .FromSql($"select * from person where id = {person.Id}")
            .First();

        Assert.That(person.Id, Is.EqualTo(found.Id));
    }

    [Test]
    public void detectDuplicatePerson()
    {
        using var _ = Repository.Context.Database.BeginTransaction();

        var person = new Person { FirstName = "First", LastName = " Last" };
        Repository.Create(person);
        Repository.SaveChanges();

        // Insert the same person again.
        var person2 = new Person { FirstName = "First", LastName = " Last" };
        Repository.Create(person2);

        // The save will throw.
        var exception = Assert.Throws<DbUpdateException>(() =>
        {
            Repository.SaveChanges();
        });
        Assert.NotNull(exception);

        var e = exception!.InnerException as PostgresException;
        Assert.NotNull(e);

        Assert.That(e!.ConstraintName, Is.EqualTo(Person.NAME_INDEX_UNIQUE));
    }
}