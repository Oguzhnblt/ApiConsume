using System.ComponentModel.DataAnnotations;

namespace HotelProject.DTOLayer.DTOs.RoomDTO
{
    public class AddRoomDTO
    {
        [Required(ErrorMessage = "Lütfen oda numarasını giriniz.")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat bilgisini giriniz.")]
        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen oda başlığını giriniz.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısını giriniz.")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen banyo sayısını giriniz.")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
