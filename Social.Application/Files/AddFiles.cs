using Social.Domain.Models;
using Social.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Social.Application.Files
{
    public class AddFiles
    {
        private readonly ApplicationDbContext _context;

        public AddFiles(ApplicationDbContext context)
        {
            _context = context;
        }

        //public async Task<DocsModel> Do(List<DocsModel> docs)//Должен принять Servises, Child, Represent
        //{
        //    var files = new List<DocsModel>();
        //    //docs получает все элементы, созданные в DocsModel, создаем новый список files и переносим туда те элементы, в которых есть файл
        //    for (int i = 0; i < docs.Count; i++)
        //    {
        //        if (docs[i].FileBody == null)
        //            continue;
        //        else
        //            files.Add(docs[i]);
        //    }


        //    foreach(var file in files)
        //    {
        //        ServisesSocialDoc servisesSocialDoc = new ServisesSocialDoc();
        //        PersonsSocialDocFile personDocFile = new PersonsSocialDocFile();
        //        PersonsSocialDoc personDoc = new PersonsSocialDoc();
        //        ServisesSocialPersonDoc servisesSocialPersonDoc = new ServisesSocialPersonDoc();
        //        servisesSocialPersonDoc.
        //    }
        //}
    }
}
