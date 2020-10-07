using AutoMapper;
using Social.Application.Files;
using Social.Application.Person;
using Social.Application.Repository.Interface;
using Social.Database;
using Social.Domain.DTOs;
using Social.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

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

                var servisesHistorys = new ServisesSocialHistorys();

                //Уникальный код
                var unicCode = UnicCodeService(childInfo, representInfo, SocialSessionId);

                var servises = _mapper.Map<ServisesSocial>(new ServisesDTO
                {
                    Id = _baseRepo.GetId(),
                    DocNum = _baseRepo.GetNumberNexDocNum(),
                    PersonId = child.PersonId,
                    Delivery = method,
                    Unic_Code = unicCode,
                    SessionId = SocialSessionId,
                });

                if (represent.IsLegalRepresent == 0)
                {
                    servises.IdCurrLegalRepresent = represent.PersonId;
                }
                else
                {
                    servises.IdCurrRepresent = represent.PersonId;
                }

                await new AddFiles(_context, _baseRepo).Do(files, childInfo, representInfo, servises);

                _baseRepo.Add(child);
                _baseRepo.Add(represent);
                //_baseRepo.Add(docs);
                _baseRepo.Add(servises);

            if (represent.IsLegalRepresent == 0)
            {
                //Записать в таблицу PERSONS_SOCIAL_LEGAL_REPRESENT
                var personsSocialLegalRepresent = new PersonsSocialLegalRepresent();
                personsSocialLegalRepresent.Id = _baseRepo.GetId();
                personsSocialLegalRepresent.IdLegalRepresent = represent.PersonId;
                personsSocialLegalRepresent.IdPerson = child.PersonId;
                personsSocialLegalRepresent.IdUser = 1;
                _baseRepo.Add(personsSocialLegalRepresent);
            }
            else
            {
                //Записать в таблицу PERSONS_SOCIAL_REPRESENT
                var personsSocialRepresent = new PersonsSocialRepresent();
                personsSocialRepresent.Id = _baseRepo.GetId();
                personsSocialRepresent.IdRepresent = represent.PersonId;
                personsSocialRepresent.IdPerson = child.PersonId;
                personsSocialRepresent.IdUser = 1;
                _baseRepo.Add(personsSocialRepresent);
            }

            if (await _baseRepo.SaveAllAsync())
            {
                servisesHistorys.Id = _baseRepo.GetId();
                servisesHistorys.ServisesId = servises.Id;
                servisesHistorys.IdUser = 1; //Системный пользователь
                servisesHistorys.IdStatus = 400; //Статус - Формирование услуги
                _baseRepo.Add(servisesHistorys);
                await _baseRepo.SaveAllAsync();

                servises.IdServiceHistorys = servisesHistorys.Id;
                //_baseRepo.Add(servises);
                
            }
            else
            {
                //Передать ошибку
                //return BadRequest("Повторите снова");
            }

            //TODO: если не сохранилось, то надо сообщить об этом
            if (await _baseRepo.SaveAllAsync())
            {
                //Передать, что все окей и номер 
                //return RedirectToAction("Success", new { DocNum });
            }

            return null;
        }

        private string UnicCodeService(ChildDTO child, RepresentDTO represent, int SocialId)
        {
            //Уникальный ключ на смену
            //ФИОРЕБЕНКАФИОРОДИТЕЛЯДАТАРОЖДЕНИЯНОМЕРНАПРАВЛЕНИЯ 
            string unicCode = $"{child.SurnameChild}{child.NameChild}{child.PatronymicChild}-{represent.SurnameRepresent}{represent.NameRepresent}{represent.PatronymicRepresent}-{SocialId}";
            return unicCode;
        }
    }
}
