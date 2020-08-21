using Microsoft.AspNetCore.Mvc;
using Social.Application.Files;
using Social.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social.UI.ViewModels
{
    public class FilesViewComponents : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public FilesViewComponents(ApplicationDbContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            return View(new DocsModel().DocsForForm());
        }
    }
}
