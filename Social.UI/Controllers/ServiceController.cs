using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Social.UI.Controllers
{
    public class ServiceController : Controller
    {
        [HttpGet]
        public IActionResult Index() => Ok(View());
        
        [HttpPost]
        public async Task<IActionResult> CreateServise()
        {
            return View("Index");
        }
    }
}
