using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeduEcommerce.ProductAttributes;

namespace TeduEcommerce.EntityFrameworkCore.Configurations.ProductAttributes;

public class ProductAttributeConfiguration : IEntityTypeConfiguration<ProductAttribute>
{
    public void Configure(EntityTypeBuilder<ProductAttribute> builder)
    {
        builder.ToTable(TeduEcommerceConsts.DbTablePrefix + "Attributes");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Code).HasMaxLength(50)
            .IsUnicode(false).IsRequired();

        builder.Property(x => x.Label)
            .HasMaxLength(50)
            .IsRequired();
    }
}