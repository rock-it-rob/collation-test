namespace Repository;

public sealed class Collation
{
    public required string Name { get; init; }

    public required string Locale { get; init; }

    public required string Provider { get; init; }

    public required bool Deterministic { get; init; }
}


public sealed class Collations
{
    public static readonly Collation UcaStrengthPrimaryCollation =
        new Collation
        {
            Name = "uca-strength-primary",
            Locale = "en-u-ks-level1",
            Provider = "icu",
            Deterministic = false
        };
}