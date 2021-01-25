using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Social.Application.Email;
using Social.Application.Files;
using Social.Application.Repository.Interface;
using Social.Application.Servises;
using Social.Database;
using Social.Domain.DTOs;
using Social.Domain.Models;

namespace Social.UI.Controllers
{
    [Route("service")]
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
            var services = new CreateServises(_context, _mapper, _baseRepo).Do(child, represent, socialSessionId, files, method);

            return RedirectToAction("Received", new { docNum = services.Result.DocNum, email = represent.Email });
        }

        [HttpGet]
        public async Task<IActionResult> Received(string docNum, string email)
        {
            if(docNum == null)
            {
                return BadRequest("Номер заявления отсутвует");
            }
            
            EmailService emailService = new EmailService();
            await emailService.SendEmailAsync(email, "Заявление отправлено в департамент образования", "Заявление" + docNum + " отправлено в департамент образования!");

            ViewBag.Message = docNum;
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var list = await _context.ServisesSocial.ToListAsync();
            IEnumerable<ServisesSocial> sortList = list.OrderBy(x => x.DateInsert);
            return View(sortList);
        }


    }
}
