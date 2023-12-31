﻿using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.DTOs.ServiceDTO
{
    public class UpdateServiceDTO
    {
        public int ServiceID { get; set; }

        [Required(ErrorMessage = "Hizmet ikon linki giriniz.")]
        public string ServiceIcon { get; set; }

        [Required(ErrorMessage = "Hizmet başlığı giriniz.")]
        [StringLength(100, ErrorMessage = "Hizmet başlığı en fazla 100 karakter olabilir.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Hizmet açıklaması giriniz.")]
        [StringLength(250, ErrorMessage = "Hizmet başlığı en fazla 250 karakter olabilir.")]
        public string Description { get; set; }
    }
}
