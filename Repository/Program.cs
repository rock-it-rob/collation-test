using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Model;



using (var context = new PersonContext())
{
    // True delete of any old person records.
    context.Set<Person>().RemoveRange(context.Set<Person>());
    context.SaveChanges();

    // Create 3 person records that would violate a regular index
    // but are allowed with the partial index.
    context.Add(
        new Person { FirstName = "Phoenix", LastName = "Wright" }
    );

    for (int i = 0; i < 2; ++i)
    {
        context.Add(
            new Person { FirstName = "Phoenix", LastName = "Wright", Active = false }
        );
    }

    context.SaveChanges();
}