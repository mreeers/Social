using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Social.Application.Files;
using Social.Application.Person;
using Social.Application.Repository.Interface;
using Social.Database;
using Social.Domain.DTOs;
using Social.Domain.Models;
using System;
using System.Collections.Generic;
using System.IO;
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
             * Добавляем файлы
             * Создаем историю
             * Сохраняем контекст
             */
            var createdChild = new CreateChildren(_baseRepo, _mapper, _context);
            var child = await createdChild.Do(childInfo);

            var createRepresent = new CreateRepresent(_baseRepo, _mapper, _context);
            var represent = await createRepresent.Do(representInfo, child);

            var servisesHistorys = new ServisesSocialHistorys();

            var servises = _mapper.Map<ServisesSocial>(new ServisesDTO
            {
                Id = _baseRepo.GetId(),
                DocNum = _baseRepo.GetNumberNexDocNum(),
                PersonId = child.PersonId,
                Delivery = method,
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

            //_baseRepo.Add(child);
            //_baseRepo.Add(represent);
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

            //В новый список сохраняются все записи, где присутствует файл
            List<DocsModel> docs = new List<DocsModel>();
            for (int i = 0; i < files.Count; i++)
            {
                if (files[i].FileBody == null)
                {
                    continue;
                }
                else
                {
                    docs.Add(files[i]);
                }
            }

            foreach (var formFile in docs)
            {
                PersonsSocialDocFile personDocFile = new PersonsSocialDocFile();
                PersonsSocialDoc personDoc = new PersonsSocialDoc();
                ServisesSocialPersonDoc servisesSocialPersonDoc = new ServisesSocialPersonDoc();

                if (formFile.FileBody.Length > 5242880)
                {
                    //Надо выкинуть ошибку 
                    string errorFile = "Размер файла не может превешать 5 мегабайт. Проверьте файл: " + formFile.FileBody.FileName;
                    //return errorFile;
                    //TODO: Выкинуть ошибку
                }

                //Записываем файл в БД со всеми зависимостями
                if (formFile != null)
                {

                    byte[] file = null;
                    // считываем переданный файл в массив байтов
                    using (var binaryReader = new BinaryReader(formFile.FileBody.OpenReadStream()))
                    {
                        file = binaryReader.ReadBytes((int)formFile.FileBody.Length);
                    }

                    // установка массива байтов
                    //Записывает файл в базу PERSONS_SOCIAL_DOC_FILE
                    personDocFile.Id = _baseRepo.GetId();
                    personDocFile.FileBody = file;
                    personDocFile.FileName = formFile.FileBody.FileName;
                    personDocFile.DateFileCreate = DateTime.Now;

                    if (personDocFile.FileBody.Length != null)
                        personDocFile.FileSize = personDocFile.FileBody.Length;

                    personDocFile.Extension = formFile.FileBody.FileName.Substring(formFile.FileBody.FileName.LastIndexOf('.'));


                    //Записывает в бузу PERSONS_SOCIAL_DOC
                    personDoc.Id = _baseRepo.GetId();

                    if (formFile.FileId == 11 || formFile.FileId == 2 || formFile.FileId == 34 || formFile.FileId == 23 || formFile.FileId == 39 || formFile.FileId == 42)
                    {
                        personDoc.PersonId = child.PersonId;
                    }
                    else
                    {
                        personDoc.PersonId = represent.PersonId;
                    }

                    personDoc.Num = formFile.Number;
                    personDoc.Ser = formFile.Series;
                    personDoc.GetDate = formFile.DateOfIssue;
                    personDoc.Get = formFile.Get;
                    personDoc.TypeDocId = formFile.FileId;
                    personDoc.Guid = Guid.NewGuid().ToString();
                    personDocFile.IdPersonsDoc = personDoc.Id;

                    servisesSocialPersonDoc.Id = _baseRepo.GetId();
                    servisesSocialPersonDoc.ServisesId = servises.Id;
                    servisesSocialPersonDoc.PersonsDocId = personDoc.Id;
                    servisesSocialPersonDoc.IdTypeDoc = formFile.FileId;
                    servisesSocialPersonDoc.IdUser = 1;

                    _baseRepo.Add(personDocFile);
                    _baseRepo.Add(personDoc);
                    _baseRepo.Add(servisesSocialPersonDoc);
                }
            }
            try
            {
                if (await _baseRepo.SaveAllAsync())
                {
                    servisesHistorys.Id = _baseRepo.GetId();
                    servisesHistorys.ServisesId = servises.Id;
                    servisesHistorys.IdUser = 1; //Системный пользователь
                    servisesHistorys.IdStatus = 400; //Статус - Формирование услуги
                    _baseRepo.Add(servisesHistorys);
                    await _baseRepo.SaveAllAsync();
                }
                else
                {
                    //Передать ошибку
                }
            }
            catch (Exception ex)
            {
                var err = ex.Message;
            }

            servises.IdServiceHistorys = servisesHistorys.Id;
            _baseRepo.Update(servises);
            await _baseRepo.SaveAllAsync();

            return servises;
        }
    }
}

