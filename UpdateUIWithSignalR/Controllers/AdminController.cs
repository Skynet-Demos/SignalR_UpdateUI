using Microsoft.AspNetCore.Mvc;
using UpdateUIWithSignalR.BL;

namespace UpdateUIWithSignalR.Controllers
{
    public class AdminController : Controller
    {
        AdminJobs adminJobs;

        public AdminController(AdminJobs adminJobs)
        {
            this.adminJobs = adminJobs; 
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProcessLoans()
        {
            await adminJobs.ProcessLoans();
            return Ok();
        }
    }
}
