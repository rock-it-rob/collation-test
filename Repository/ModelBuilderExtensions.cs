using Microsoft.EntityFrameworkCore;

namespace Repository;

public static class ModelBuilderExtensions
{
    public static void HasCollation(this ModelBuilder modelBuilder, ICollation collation)
    {
        modelBuilder.HasCollation(
            name: collation.Name,
            locale: collation.Locale,
            provider: collation.Provider,
            deterministic: collation.Deterministic
        );
    }
}