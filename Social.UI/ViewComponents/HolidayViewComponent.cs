using Microsoft.AspNetCore.Mvc;
using Social.Application.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Social.UI.ViewComponents
{
    public class HolidayViewComponent : ViewComponent
    {
        private readonly IHoliday _holiday;

        public HolidayViewComponent(IHoliday holiday)
        {
            _holiday = holiday;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var holidays = await _holiday.GetAllSession();
            return View(holidays);
        }
    }
}
