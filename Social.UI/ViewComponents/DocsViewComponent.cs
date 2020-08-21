using Microsoft.AspNetCore.Mvc;
using Social.Application.Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social.UI.ViewComponents
{
    public class DocsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var docs = new DocsModel().DocsForForm();
            return View(docs);
        }
    }
}
