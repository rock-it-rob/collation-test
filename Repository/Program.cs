using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Model;


using var context = new PersonContext();
var personRepository = new PersonRepository(context);
var repository = (IRepository<Person, long>)personRepository;

// True delete of any old person records.
repository.Context.Person.RemoveRange(repository.Context.Person);

// Create 3 person records that would violate a regular index
// but are allowed with the partial index.
repository.Create(
    new Person { FirstName = "Phoenix", LastName = "Wright" }
);

for (int i = 0; i < 2; ++i)
{
    repository.Create(
        new Person { FirstName = "Phoenix", LastName = "Wright", Active = false }
    );
}

repository.SaveChanges();