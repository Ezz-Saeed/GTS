using Microsoft.AspNetCore.Mvc;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report.Dictionary;

namespace GTS.Controllers
{
    public class ReportController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        private readonly string _filePath;
        private readonly string _imgPath;

        public ReportController(IWebHostEnvironment environment)
        {
            _environment = environment;

            _filePath = $"{environment.WebRootPath}/MRT";
            _imgPath = $"{environment.WebRootPath}/Images";

        }
      

        public IActionResult OpenReport()
        {
            string path = Path.Combine(_filePath, "PrintCashir.mrt");
            string report = System.IO.File.ReadAllText(path);

            return Json(new { report });
        }

        
        public IActionResult OpenImage()
        {
            
            string relativePath = $"/Images/profile.jpg"; 
            string imageUrl = Url.Content($"{relativePath}");

            return Json(new { imgUrl = imageUrl });
        }



    }
}
