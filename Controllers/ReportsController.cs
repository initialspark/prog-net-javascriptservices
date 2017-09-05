using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.NodeServices;

namespace Demo.Controllers
{
    [Route("api/[controller]")]
    public class ReportsController : Controller
    {
        [HttpGet("sales")]
        public async Task<IActionResult> Sales()
        {
            return Content("Nothing here to see :)");
        }
    }
}
