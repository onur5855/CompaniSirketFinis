using CompaniSirket.Models.Entity.BaseEntity;
using CompaniSirket.Models.Enum;

namespace CompaniSirket.Models.Entity.Entitiler
{
    public class Employee:BaseClas
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime DogumTarihi { get; set; }
        public int Tc { get; set; }
        public decimal Maas { get; set; }
        public Egitim EgitimDurumu { get; set; }

        public virtual int CompanyID { get; set; }
        public virtual Company EmployeCompany { get; set; }
    }
}
