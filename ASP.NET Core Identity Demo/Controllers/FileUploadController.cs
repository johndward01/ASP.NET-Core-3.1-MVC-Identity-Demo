using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace ASP.NET_Core_Identity_Demo.Controllers
{
    public class FileUploadController : Controller
    {
        private readonly string _uploaded = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploaded");

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> Upload(IFormFile formFile)
        {
            if (formFile != null)
            {
                var path = Path.Combine(_uploaded, Guid.NewGuid() + Path.GetExtension(formFile.FileName));

                using var stream = new FileStream(path, FileMode.Create);
                await formFile.CopyToAsync(stream);

            }
            return RedirectToAction("Index");
        }
    }
}
