using Social.Domain.Models;
using Social.Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Social.Application.Repository.Interface
{
    public interface IHoliday
    {
        Task<IEnumerable<SocialSession>> GetAllSession();
    }
}
