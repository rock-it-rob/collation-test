namespace Repository;

public sealed class Collation
{
    public required string Name { get; init; }

    public required string Locale { get; init; }

    public required string Provider { get; init; }

    public required bool Deterministic { get; init; }
}