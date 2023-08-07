using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileProcessController : ControllerBase
    {
        private readonly string _textUploadPath = "TextUploads"; // Hedef klasör adı

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UploadText(IFormFile file)
        {
            try
            {
                if (file == null || file.Length == 0)
                {
                    return BadRequest("Yüklenecek bir metin dosyası bulunamadı.");
                }

                if (!IsTextFile(file))
                {
                    return BadRequest("Sadece metin dosyaları yüklenebilir.");
                }

                // Yüklenen metin belgesinin adını ve uzantısını alalım (örn. "sample.txt")
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                // Metin belgesini yüklemek için tam yol oluşturalım
                string filePath = Path.Combine(_textUploadPath, fileName);

                // Eğer hedef klasör mevcut değilse oluşturalım
                if (!Directory.Exists(_textUploadPath))
                {
                    Directory.CreateDirectory(_textUploadPath);
                }

                // Metin belgesini yükleyelim
                using (var stream = new FileStream(filePath, FileMode.Create))
                using (var reader = new StreamReader(file.OpenReadStream()))
                {
                    await reader.BaseStream.CopyToAsync(stream);
                }

                // İsteğe bağlı olarak, yükleme başarılı mesajı dönebiliriz
                return Ok("Metin yükleme başarılı.");
            }
            catch (Exception ex)
            {
                // Hata durumunda uygun bir hata mesajı dönebiliriz
                return BadRequest($"Metin yüklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private bool IsTextFile(IFormFile file)
        {
            // Desteklenen metin dosya uzantılarını burada tanımlayabilirsiniz.
            // Bu örnekte sadece .txt uzantısını kontrol ediyoruz.
            string[] supportedExtensions = { ".txt", ".pdf" };
            string fileExtension = Path.GetExtension(file.FileName).ToLowerInvariant();
            return Array.Exists(supportedExtensions, ext => ext == fileExtension);
        }
    }
}
