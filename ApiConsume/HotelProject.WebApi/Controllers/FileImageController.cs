using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileImageController : ControllerBase
    {

        private readonly string _imageUploadPath = "Uploads"; // Hedef klasör adı

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            try
            {
                if (file == null || file.Length == 0)
                {
                    return BadRequest("Yüklenecek bir resim dosyası bulunamadı.");
                }

                if (!IsImageFile(file))
                {
                    return BadRequest("Sadece resim dosyaları yüklenebilir.");
                }

                // Yüklenen resmin adını ve uzantısını alalım (örn. "sample.jpg")
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                // Resmi yüklemek için tam yol oluşturalım
                string filePath = Path.Combine(_imageUploadPath, fileName);

                // Eğer hedef klasör mevcut değilse oluşturalım
                if (!Directory.Exists(_imageUploadPath))
                {
                    Directory.CreateDirectory(_imageUploadPath);
                }

                // Resmi yükleyelim
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                // İsteğe bağlı olarak, yükleme başarılı mesajı dönebiliriz
                return Ok("Resim yükleme başarılı.");
            }
            catch (Exception ex)
            {
                // Hata durumunda uygun bir hata mesajı dönebiliriz
                return BadRequest($"Resim yüklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private bool IsImageFile(IFormFile file)
        {
            // Desteklenen resim dosya uzantılarını burada tanımlayabilirsiniz.
            // Bu örnekte sadece yaygın resim uzantılarını kontrol ediyoruz.
            string[] supportedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            string fileExtension = Path.GetExtension(file.FileName).ToLowerInvariant();
            return Array.Exists(supportedExtensions, ext => ext == fileExtension);
        }
    }
}

