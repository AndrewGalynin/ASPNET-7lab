using Microsoft.AspNetCore.Mvc;
using Lab_7.Models;
using System.IO;

namespace Lab_7.Controllers
{
    public class FileController : Controller
    {
        [HttpGet]
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DownloadFile(FileViewModel model)
        {
            var content = $"Ім'я: {model.FirstName}\nПрізвище: {model.LastName}";
            var filePath = $"{model.FileName}.txt";

            System.IO.File.WriteAllText(filePath, content);

            return File(System.IO.File.ReadAllBytes(filePath), "text/plain", filePath);
        }
    }
}
