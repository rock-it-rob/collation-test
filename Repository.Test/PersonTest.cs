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
}