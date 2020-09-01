using Microsoft.EntityFrameworkCore;
using Social.Domain.Models;
using Social.Application.Repository.Interface;
using Social.Database;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Social.Application.Repository
{
    public class Base : IBase
    {
        private readonly ApplicationDbContext _context;

        public Base(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public DateTime GetDateTimeServer()
        {
            var DateTimeNow = DateTime.Now;
            return DateTimeNow;
        }

        public decimal GetId()
        {
            string getIdSql = "select uid_sequence.nextval from dual";

            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                try
                {
                    command.Connection.Open();
                    command.CommandText = getIdSql;
                    var seqvalId = command.ExecuteScalar().ToString();
                    command.Connection.Close();
                    return decimal.Parse(seqvalId);

                }
                catch (Exception ex)
                {
                    throw new Exception();
                }
            }
        }

        public string GetNumberNexDocNum()
        {
            string sql = "select S_NEW_SERVISES_SOCIAL_NUM.NEXTVAL from dual";
            string NumberFormatString = "СП-{0}";
            int baseNumber = 100000;

            using(var command = _context.Database.GetDbConnection().CreateCommand())
            {
                try
                {
                    command.Connection.Open();
                    command.CommandText = sql;
                    var seqvalDocNum = Convert.ToInt64(command.ExecuteScalar().ToString());
                    string docNumber = String.Format(NumberFormatString, seqvalDocNum + baseNumber);
                    command.Connection.Close();
                    return docNumber;
                }
                catch (Exception ex)
                {
                    throw new Exception();
                }
            }
        }

        public async Task<IEnumerable<TypeDoc>> GetTypeDocs()
        {
            var typeDocs = await _context.TypeDocs.ToListAsync();
            return typeDocs;
        }

        public async Task<bool> SaveAllAsync()
        {
            if (await _context.SaveChangesAsync() > 0)
                return true;
            return false;
        }
    }
}
