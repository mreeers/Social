using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Social.Application.Files;
using Social.Application.Repository.Interface;
using Social.Application.Servises;
using Social.Database;
using Social.Domain.DTOs;
using Social.Domain.Models;

namespace Social.UI.Controllers
{
    [Route("controller")]
    public class ServiceController : Controller
    {
        private readonly IBase _baseRepo;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public ServiceController(IBase baseRepo, IMapper mapper, ApplicationDbContext context)
        {
            _baseRepo = baseRepo;
            _mapper = mapper;
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(ChildDTO child, RepresentDTO represent, int socialSessionId, List<DocsModel> files, int method)
        {
            var services = new CreateServises(_context, _mapper, _baseRepo);
            await services.Do(child, represent, socialSessionId, files, method);
            
            return Redirect("/");
        }
    }
}
