namespace Repository;

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