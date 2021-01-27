using AutoMapper;
using Social.Domain.Models;
using Social.Application.Repository.Interface;
using Social.Domain.DTOs;
using System.Threading.Tasks;
using Social.Database;
using System.Linq;

namespace Social.Application.Person
{
    public class CreateChildren
    {
        private readonly IBase _baseRepo;
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public CreateChildren(IBase baseRepo, IMapper mapper, ApplicationDbContext context)
        {
            _baseRepo = baseRepo;
            _mapper = mapper;
            _context = context;
        }

        public async Task<PersonsSocial> Do(ChildDTO request)
        {
            //TODO: Добавить проверку, есть ли этот ребенок в системе
            var child = _context.PersonsSocial.SingleOrDefault(x => x.Name == request.NameChild && 
                                                                x.Surname == request.SurnameChild && 
                                                                x.Patronymic == request.PatronymicChild &&
                                                                x.Bdate == request.Bdate);

            if(child != null)
            {
                return child;
            }

            else
            {
                child = _mapper.Map<PersonsSocial>(new ChildDTO
                {
                    PersonId = _baseRepo.GetId(),
                    NameChild = request.NameChild,
                    SurnameChild = request.SurnameChild,
                    PatronymicChild = request.PatronymicChild,
                    Bdate = request.Bdate,
                    Birthplace = request.Birthplace,
                    Sex = request.Sex,
                    Snils = request.Snils
                });
            }
            
            _baseRepo.Add(child);
            await _baseRepo.SaveAllAsync();

            return child;
        }

    }
}
