namespace Repository;

public sealed class UcaStrengthPrimaryCollation : ICollation
{
    public static readonly UcaStrengthPrimaryCollation INSTANCE = new UcaStrengthPrimaryCollation();

    public string Name => "uca-strength-primary";

    public string Locale => "en-u-ks-level1";

    public string Provider => "icu";

    public bool Deterministic => false;

    private UcaStrengthPrimaryCollation()
    {
    }
}