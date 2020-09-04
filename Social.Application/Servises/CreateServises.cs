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
using Social.Application.Files;

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

        public async Task<ServisesSocial> Do(ChildDTO childInfo, RepresentDTO representInfo, int SocialSessionId, List<DocsModel> files, int method)
        {
            /* Создаем ребенка
             *      Проверяем есть ли такой в базе
             * Создаем родителя
             *      Проверяем есть ли такой в базе
             * Создаем "связь" ребенок-родитель/представитель
             * Создаем сервис
             *      Проверяем нет ли такого заявления по уникальному ключу Unic_code
             * Добавляем файлы
             * Создаем историю
             * Сохраняем контекст
             */
            var createdChild = new CreateChildren(_baseRepo, _mapper);
            var child = await createdChild.Do(childInfo);

            var createRepresent = new CreateRepresent(_baseRepo, _mapper);
            var represent = await createRepresent.Do(representInfo);

            

            var servises = _mapper.Map<ServisesSocial>(new ServisesDTO
            {
                Id = _baseRepo.GetId(),
                DocNum = _baseRepo.GetNumberNexDocNum(),
                PersonId = child.PersonId,
                Delivery = method,
                Unic_Code = unicCodeService(childInfo, representInfo, SocialSessionId).ToString()
            });


            _baseRepo.Add(createdChild);
            _baseRepo.Add(createRepresent);

            if (represent.IsLegalRepresent == 0)
            {
                servises.IdCurrLegalRepresent = represent.PersonId;
            }
            else
            {
                servises.IdCurrRepresent = represent.PersonId;
            }

            return null;
        }

        private async Task<string> unicCodeService(ChildDTO child, RepresentDTO represent, int SocialId)
        {
            //Уникальный ключ на смену
            //ФИОРЕБЕНКАФИОРОДИТЕЛЯДАТАРОЖДЕНИЯНОМЕРНАПРАВЛЕНИЯ 
            string unicCode = $"{child.SurnameChild}{child.NameChild}{child.PatronymicChild}-{represent.SurnameRepresent}{represent.NameRepresent}{represent.PatronymicRepresent}-{SocialId}";
            return unicCode;
        }
    }
}
