namespace Repository;

public interface ICollation
{
    public string Name { get; }

    public string Locale { get; }

    public string Provider { get; }

    public bool Deterministic { get; }
}