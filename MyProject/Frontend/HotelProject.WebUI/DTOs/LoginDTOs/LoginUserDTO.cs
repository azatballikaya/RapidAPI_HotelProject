using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProject.WebUI.DTOs.LoginDTOs
{
    public class LoginUserDTO
    {
        [Required (ErrorMessage ="Kullanıcı adını giriniz")]
        public string UserName { get; set; }
        [Required (ErrorMessage ="Şifreyi giriniz.")]

        public string Password { get; set; }
    }
}