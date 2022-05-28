using CompaniSirket.Models.Entity.BaseEntity;

namespace CompaniSirket.Models.Entity.Entitiler
{
    public class Company: BaseClas
    {
        public string Name { get; set; }
        public string Kurucu_Adi { get; set; }
        public string Kurucu_Soyadi { get; set; }
        public DateTime Kurulum_Tarihi { get; set; }
        public string Adres_Bilgileri { get; set; }


        public virtual List<Employee> Employees { get; set; }

    }
}
