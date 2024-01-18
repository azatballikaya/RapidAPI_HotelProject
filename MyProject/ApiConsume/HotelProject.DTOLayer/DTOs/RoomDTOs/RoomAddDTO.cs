﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DTOLayer.DTOs.RoomDTOs
{
    public class RoomAddDTO
    {
        [Required (ErrorMessage ="Lütfen oda numarasını giriniz.")]
        public int RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage ="Lütfen fiyat giriniz.")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Lütfen başlık giriniz.")]

        public string Title { get; set; }
        [Required(ErrorMessage = "Lütfen yatak sayısı giriniz.")]

        public string BedCount { get; set; }
        [Required(ErrorMessage = "Lütfen banyo giriniz.")]

        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}