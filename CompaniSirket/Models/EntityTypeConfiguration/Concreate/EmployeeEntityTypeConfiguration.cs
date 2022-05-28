using CompaniSirket.Models.Entity.Entitiler;
using CompaniSirket.Models.EntityTypeConfiguration.BaseEntitType;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompaniSirket.Models.EntityTypeConfiguration.Concreate
{
    public class EmployeeEntityTypeConfiguration: BaseEntityTypeConfigurations<Employee>
    {
        public override void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(a => a.Adi).IsRequired();
            builder.Property(a => a.Soyadi).IsRequired();
            builder.Property(a => a.DogumTarihi).IsRequired();
            builder.Property(a => a.Tc).IsRequired();
            builder.Property(a => a.Maas).IsRequired();
            builder.Property(a => a.EgitimDurumu).IsRequired();
            // employesdeki bi seikete baglıdır-companiylerinde comca calısanları var dedik ve bunlar employesdaki campaniID ile bagldıır dedik
            builder.HasOne(a=>a.EmployeCompany).WithMany(a=>a.Employees).HasForeignKey(a=>a.CompanyID);

            base.Configure(builder);
        }
    }
}
