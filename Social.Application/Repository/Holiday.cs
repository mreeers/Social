using Microsoft.EntityFrameworkCore;
using Social.Domain.Models;
using Social.Application.Repository.Interface;
using Social.Database;
using Social.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Application.Repository
{
    public class Holiday : IHoliday
    {
        private readonly ApplicationDbContext _context;

        public Holiday(ApplicationDbContext context)
        {
            _context = context;
        }

        private async Task<IEnumerable<SocialSession>> socialSessionAsync()
        {
            var socialSession = await _context.SocialSession
                 .Include(p => p.SocialPlace)
                     .ThenInclude(t => t.SocialWay)
                     .ThenInclude(x => x.SocialPeriod)
                     .ThenInclude(z => z.SocialWay)
                 .Include(a => a.SocialDelivery)
                 .ToListAsync();

            return socialSession;
        }

        public async Task<IEnumerable<SocialSession>> GetAllSession()
        {
            var holiday = socialSessionAsync().Result.Where(x => x.SocialPlace.SocialWay.SocialPeriod.IsActive != 1);

            return holiday;
        }
    }
}
