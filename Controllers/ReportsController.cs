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
        public async Task<IActionResult> Sales([FromServices] INodeServices nodeServices, [FromServices] IHostingEnvironment hostingEnvironment)
        {
            var reportPath = hostingEnvironment.WebRootFileProvider.GetFileInfo("html/report.html");
            
            var options = new { format = "Letter" };            
            var data = new {html = System.IO.File.ReadAllText(reportPath.PhysicalPath)};

            var result = await nodeServices.InvokeAsync<Stream>("generatePdfReport.js",options,data);
            return  File(result, "application/pdf");
        }
    }
}
