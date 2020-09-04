using AutoMapper;
using Social.Domain.Models;
using Social.Application.Repository.Interface;
using Social.Domain.DTOs;
using System.Threading.Tasks;

namespace Social.Application.Person
{
    public class CreateChildren
    {
        private readonly IBase _baseRepo;
        private readonly IMapper _mapper;

        public CreateChildren(IBase baseRepo, IMapper mapper)
        {
            _baseRepo = baseRepo;
            _mapper = mapper;
        }

        public async Task<PersonsSocial> Do(ChildDTO request)
        {
            //TODO: Добавить проверку, есть ли этот ребенок в системе

            var child = _mapper.Map<PersonsSocial>(new ChildDTO
            {
                PersonId = _baseRepo.GetId(),
                NameChild = request.NameChild,
                SurnameChild = request.SurnameChild,
                PatronymicChild = request.PatronymicChild,
                Bdate = request.Bdate,
                Birthplace = request.Birthplace,
                Sex = request.Sex
            });
            //_baseRepo.Add(child);
            //await _baseRepo.SaveAllAsync();

            return child;
        }

    }
}
