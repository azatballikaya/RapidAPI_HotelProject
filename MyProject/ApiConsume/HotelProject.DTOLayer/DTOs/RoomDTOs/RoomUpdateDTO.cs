using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DTOLayer.DTOs.RoomDTOs
{
    public class RoomUpdateDTO

    {
        public int RoomId { get; set; }
        [Required (ErrorMessage ="Lütfen oda numarasını giriniz.")]
        public int RoomNumber { get; set; }
        [Required(ErrorMessage = "Lütfen oda görseli giriniz.")]

        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage ="Lütfen fiyat giriniz.")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen başlık giriniz.")]
        [StringLength (100,ErrorMessage ="Lütfen en fazla 100 karakter giriniz.")]

        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısı giriniz.")]

        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo giriniz.")]

        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Lütfen açıklama giriniz.")]

        public string Description { get; set; }
    }
}
