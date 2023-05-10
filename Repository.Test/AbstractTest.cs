namespace Repository.Test;

public abstract class AbstractTest
{
    protected PersonRepository Repository { get; }

    public AbstractTest()
        => Repository = new PersonRepository(new PersonContext());
}