using AutoMapper;
using Social.Domain.Models;
using Social.Application.Repository.Interface;
using Social.Domain.DTOs;
using System.Threading.Tasks;
using Social.Database;
using System.Linq;

namespace Social.Application.Person
{
    public class CreateRepresent
    {
        private readonly IBase _baseRepo;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public RepresentDTO RepresentDTO { get; set; }

        public CreateRepresent(IBase baseRepo, IMapper mapper, ApplicationDbContext context)
        {
            _baseRepo = baseRepo;
            _mapper = mapper;
            _context = context;
        }

        public async Task<PersonsSocial> Do(RepresentDTO request, PersonsSocial child)
        {
            //TODO: Добавить проверку, есть ли этот родитель в системе
            var represent = _context.PersonsSocial.SingleOrDefault(x => x.Name == request.NameRepresent &&
                                                                x.Surname == request.SurnameRepresent &&
                                                                x.Patronymic == request.PatronymicRepresent &&
                                                                x.PhoneMobile == request.PhoneMobile
                                                                );
            if(represent == null)
            {
                represent = _mapper.Map<PersonsSocial>(new RepresentDTO
                {
                    PersonId = _baseRepo.GetId(),
                    NameRepresent = request.NameRepresent,
                    SurnameRepresent = request.SurnameRepresent,
                    PatronymicRepresent = request.PatronymicRepresent,
                    Email = request.Email,
                    PhoneHome = request.PhoneHome,
                    PhoneMobile = request.PhoneMobile
                });
            }
            
            else
            {
                return represent;
            }

            _baseRepo.Add(represent);
            await _baseRepo.SaveAllAsync();

            return represent;
        }
    }
}
