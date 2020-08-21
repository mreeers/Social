using Shop.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Social.Application.Repository.Interface
{
    public interface IBase
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAllAsync();
        decimal GetId();
        Task<IEnumerable<TypeDoc>> GetTypeDocs();
        string GetNumberNexDocNum();
        DateTime GetDateTimeServer();
    }
}
