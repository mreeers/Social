using Social.Domain.Models;
using Social.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Social.Application.Repository.Interface;
using Social.Domain.DTOs;

namespace Social.Application.Files
{
    public class AddFiles
    {
        private readonly ApplicationDbContext _context;
        private readonly IBase _baseRepo;

        public AddFiles(ApplicationDbContext context, IBase baseRepo)
        {
            _context = context;
            _baseRepo = baseRepo;
        }

        public async Task<List<DocsModel>> Do(List<DocsModel> docs, ChildDTO childInfo, RepresentDTO representInfo, ServisesSocial servises)//Должен принять Servises, Child, Represent
        {
            //В новый список сохраняются все записи, где присутствует файл
            List<DocsModel> files = new List<DocsModel>();
            for (int i = 0; i < docs.Count; i++)
            {
                if (docs[i].FileBody == null)
                {
                    continue;
                }
                else
                {
                    files.Add(docs[i]);
                }
            }

            foreach (var formFile in files)
            {
                ServisesSocialDoc servisesSocialDoc = new ServisesSocialDoc();
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
                    personDocFile.FileSize = personDocFile.FileBody.Length;
                    personDocFile.Extension = formFile.FileBody.FileName.Substring(formFile.FileBody.FileName.LastIndexOf('.'));


                    //Записывает в бузу PERSONS_SOCIAL_DOC
                    personDoc.Id = _baseRepo.GetId();

                    if (formFile.FileId == 11 || formFile.FileId == 2 || formFile.FileId == 34 || formFile.FileId == 23 || formFile.FileId == 39 || formFile.FileId == 42)
                    {
                        personDoc.PersonId = childInfo.PersonId;
                    }
                    else
                    {
                        personDoc.PersonId = representInfo.PersonId;
                    }

                    personDoc.Num = formFile.Number;
                    personDoc.Ser = formFile.Series;
                    personDoc.Bdate = formFile.DateOfIssue;
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
                    _baseRepo.Add(servisesSocialDoc);
                    _baseRepo.Add(servisesSocialPersonDoc);
                }
            }

            return files;
        }
    }
}
