using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository;

public static class ModelBuilderExtensions
{
    public static ModelBuilder HasCollation(this ModelBuilder modelBuilder, Collation collation)
        => modelBuilder.HasCollation(
            name: collation.Name,
            locale: collation.Locale,
            provider: collation.Provider,
            deterministic: collation.Deterministic
        );

    public static PropertyBuilder UseCollation(this PropertyBuilder propertyBuilder, Collation collation)
        => propertyBuilder.UseCollation(collation.Name);
}