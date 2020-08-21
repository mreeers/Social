using Microsoft.AspNetCore.Mvc;
using Social.Domain.DTOs;

namespace Social.UI.ViewComponents
{
    public class RepresentViewComponent : ViewComponent
    {
        private RepresentDTO RepresentDTO { get; set; }
        public IViewComponentResult Invoke()
        {
            return View(RepresentDTO);
        }
    }
}
