using System.ComponentModel.DataAnnotations;

namespace CompaniSirket.DataTransferObject
{
    public class CompanyUpdateDTO
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "bu alan gereklidir")]
        [MinLength(3), MaxLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage = "bu alan gereklidir")]
        [MinLength(3), MaxLength(50)]
        public string Kurucu_Adi { get; set; }
        [Required(ErrorMessage = "bu alan gereklidir")]
        [MinLength(3), MaxLength(50)]
        public string Kurucu_Soyadi { get; set; }
        [Required(ErrorMessage = "bu alan gereklidir")]
        public DateTime Kurulum_Tarihi { get; set; }
        [Required(ErrorMessage = "bu alan gereklidir")]
        [MinLength(20), MaxLength(250)]
        public string Adres_Bilgileri { get; set; }

    }
}
