using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTOs.RegisterDTOs
{
    public class CreateRegisterDTO
    {
        [Required(ErrorMessage ="Ad Alanı Gereklidir")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyad Alanı Gereklidir")]

        public string Surname { get; set; }
        [Required(ErrorMessage = "Kullanıcı adı Gereklidir")]

        public string UserName { get; set; }
        [Required(ErrorMessage = "Mail Gereklidir")]

        public string Mail { get; set; }
        [Required(ErrorMessage = "Şifre Gereklidir")]

        public string Password { get; set; }
        [Required(ErrorMessage = "Şifre Tekrar Gereklidir")]
        [Compare("Password",ErrorMessage ="Şifreler uyuşmuyor.")]
        public string PasswordConfirm { get; set; }
    }
}
