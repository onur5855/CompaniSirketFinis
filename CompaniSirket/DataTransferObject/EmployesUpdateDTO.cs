using CompaniSirket.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace CompaniSirket.DataTransferObject
{
    public class EmployesUpdateDTO
    {

        public int ID { get; set; }
        [Required]
        [MinLength(3), MaxLength(50)]
        public string Adi { get; set; }
        [Required]
        [MinLength(3), MaxLength(50)]
        public string Soyadi { get; set; }
        [Required]
        public DateTime DogumTarihi { get; set; }
        [Required]
        [MinLength(11), MaxLength(11)]
        public string Tc { get; set; }  // tc ile işlem yapmıcagımız için string olarak tutduk 
        [Required]
        public decimal Maas { get; set; }
        [Required]
        public Egitim EgitimDurumu { get; set; }
        [Required]
        public int CompanyID { get; set; }


    }
}
