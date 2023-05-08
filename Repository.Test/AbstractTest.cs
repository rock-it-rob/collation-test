namespace Repository.Test;

public abstract class AbstractTest
{
    protected readonly PersonContext _context;

    public AbstractTest()
        => _context = new PersonContext();
}