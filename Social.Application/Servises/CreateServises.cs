using AutoMapper;
using Social.Domain.Models;
using Social.Application.Repository.Interface;
using Social.Database;
using Social.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Social.Application.Person;

namespace Social.Application.Servises
{
    public class CreateServises
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IBase _baseRepo;

        public CreateServises(ApplicationDbContext context, IMapper mapper, IBase baseRepo)
        {
            _context = context;
            _mapper = mapper;
            _baseRepo = baseRepo;
        }

        public async Task<ServisesSocial> Do(ChildDTO child, RepresentDTO represent, int SocialSessionId, List<DocsDTO> files, int method)
        {
            var createChild = new CreateChildren(_baseRepo, _mapper);
            await createChild.Do(child);

            var createRepresent = new CreateRepresent(_baseRepo, _mapper);
            await createRepresent.Do(represent);

            var servises = _mapper.Map<ServisesSocial>(new ServisesDTO
            {
                Id = _baseRepo.GetId(),
                PersonId = createChild.ChildDTO.PersonId,
                SessionId = SocialSessionId,
                Delivery = method,
                DocNum = _baseRepo.GetNumberNexDocNum()
            });



            return servises;
        }
    }
}
