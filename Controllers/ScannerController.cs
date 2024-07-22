using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class ScannerController : Controller
    {
        public IActionResult Scanner()
        {
            return View();
        }
    }
}