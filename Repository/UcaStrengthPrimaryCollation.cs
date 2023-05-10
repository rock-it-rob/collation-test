namespace Repository;

public sealed class UcaStrengthPrimaryCollation : ICollation
{
    public string Name => "uca-strength-primary";

    public string Locale => "en-u-ks-level1";

    public string Provider => "icu";

    public bool Deterministic => false;
}