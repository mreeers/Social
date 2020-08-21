using Microsoft.AspNetCore.Mvc;
using Social.Domain.DTOs;

namespace Social.UI.ViewModels
{
    public class ChildViewComponent : ViewComponent
    {
        private ChildDTO ChildDTO { get; set; }
        public IViewComponentResult Invoke()
        {
            return View(ChildDTO);
        }
    }
}
