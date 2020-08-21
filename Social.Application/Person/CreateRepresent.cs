using AutoMapper;
using Shop.Domain.Models;
using Social.Application.Repository.Interface;
using Social.Domain.DTOs;
using System.Threading.Tasks;

namespace Social.Application.Person
{
    public class CreateRepresent
    {
        private readonly IBase _baseRepo;
        private readonly IMapper _mapper;

        public CreateRepresent(IBase baseRepo, IMapper mapper)
        {
            _baseRepo = baseRepo;
            _mapper = mapper;
        }

        public async Task<PersonsSocial> Do(RepresentDTO request)
        {
            //TODO: Добавить проверку, есть ли этот родитель в системе
            var represent = _mapper.Map<PersonsSocial>(new RepresentDTO
            {
                PersonId = _baseRepo.GetId(),
                Name = request.Name,
                Surname = request.Surname,
                Patronymic = request.Patronymic,
                Email = request.Email,
                PhoneHome = request.PhoneHome,
                PhoneMobile = request.PhoneMobile
            });

            _baseRepo.Add(request);
            await _baseRepo.SaveAllAsync();

            return represent;
        }
    }
}
