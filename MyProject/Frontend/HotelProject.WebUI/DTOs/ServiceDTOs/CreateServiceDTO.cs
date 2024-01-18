using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTOs.ServiceDTOs
{
    public class CreateServiceDTO
    {
        [Required(ErrorMessage ="Servis ikon linki giriniz.")]
        public string ServiceIcon { get; set; }
        [Required(ErrorMessage = "Hizmet başlığı giriniz.")]
        [StringLength(100,ErrorMessage ="Hizzmet başlığı en fazla 100 karakter olabilir.")]

        public string Title { get; set; }
        public string Description { get; set; }
    }
}
