using HotelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace HotelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Index(AdminMailViewModel adminMailViewModel)
        {
            MimeMessage mimeMessage = new MimeMessage();

            MailboxAddress mailboxAddressFrom = new MailboxAddress("HotelierAdmin", "van.haag36@ethereal.email"); // KİMDEN
            mimeMessage.From.Add(mailboxAddressFrom);

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", adminMailViewModel.ReceiverMail); // KİME 
            mimeMessage.To.Add(mailboxAddressTo);

            var bodyBuilder = new BodyBuilder();  // MESAJIN İÇERİĞİ
            bodyBuilder.TextBody = adminMailViewModel.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();

            mimeMessage.Subject = adminMailViewModel.Subject;

            SmtpClient client = new SmtpClient();
            client.Connect("smtp.ethereal.email", 587, false);
            client.Authenticate("van.haag36@ethereal.email", "SDKUZe5KP8E2uAfKm3");
            client.Send(mimeMessage);
            client.Disconnect(true);

            return View();
        }
    }
}
