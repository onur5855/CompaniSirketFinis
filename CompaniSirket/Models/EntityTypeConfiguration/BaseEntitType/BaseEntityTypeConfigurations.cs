using CompaniSirket.Models.Entity.BaseEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompaniSirket.Models.EntityTypeConfiguration.BaseEntitType
{
    public class BaseEntityTypeConfigurations<T> : IEntityTypeConfiguration<T> where T : BaseClas
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(a => a.ID);
            builder.Property(a => a.Isactive).IsRequired();//aktiklik gerekli-Create ederken  otomatik ekliyoru bunu yazmasakda olur 



        }
    }
}
