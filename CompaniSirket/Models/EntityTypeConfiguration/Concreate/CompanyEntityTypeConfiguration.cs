using CompaniSirket.Models.Entity.Entitiler;
using CompaniSirket.Models.EntityTypeConfiguration.BaseEntitType;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompaniSirket.Models.EntityTypeConfiguration.Concreate
{
    public class CompanyEntityTypeConfiguration: BaseEntityTypeConfigurations<Company>
    {
        public override void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(a=>a.Name).IsRequired(true);
            builder.Property(a=>a.Kurucu_Adi).IsRequired(true);
            builder.Property(a=>a.Kurucu_Soyadi).IsRequired(true);
            builder.Property(a=>a.Kurulum_Tarihi).IsRequired(true);
            builder.Property(a=>a.Adres_Bilgileri).IsRequired(true);
            base.Configure(builder);
        }

    }
}
