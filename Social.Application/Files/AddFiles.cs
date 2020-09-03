using Social.Domain.Models;
using Social.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Social.Application.Files
{
    public class AddFiles
    {
        private readonly ApplicationDbContext _context;

        public AddFiles(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<DocsModel>> Do(List<DocsModel> docs)//Должен принять Servises, Child, Represent
        {
            var files = docs;
            //docs получает все элементы, созданные в DocsModel, создаем новый список files и переносим туда те элементы, в которых есть файл
            return files;
        }
    }
}
