using System.ComponentModel.DataAnnotations;

namespace HotelProject.DTOLayer.DTOs.RoomDTO
{
    public class UpdateRoomDTO
    {
        public int RoomID { get; set; }

        [Required(ErrorMessage = "Lütfen oda numarasını giriniz.")]
        public string RoomNumber { get; set; }

        [Required(ErrorMessage = "Lütfen oda görselini yükleyiniz.")]
        public string RoomCoverImage { get; set; }

        [Required(ErrorMessage = "Lütfen fiyat bilgisini giriniz.")]

        public int Price { get; set; }

        [Required(ErrorMessage = "Lütfen oda başlığını giriniz.")]
        [StringLength(100, ErrorMessage = "Lütfen en fazla 100 karakter giriniz.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Lütfen yatak sayısını giriniz.")]
        public string BedCount { get; set; }

        [Required(ErrorMessage = "Lütfen banyo sayısını giriniz.")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }

        [Required(ErrorMessage = "Lütfen açıklama giriniz.")]
        public string Description { get; set; }
    }
}
