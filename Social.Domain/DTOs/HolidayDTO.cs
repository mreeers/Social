using System;
using System.Collections.Generic;
using System.Text;

namespace Social.Domain.DTOs
{
    public class HolidayDTO
    {
        public decimal DeliveryId { get; set; }
        public int? DeliveryMethod { get; set; }
        public decimal SessionId { get; set; }
        public decimal SessionNumSession { get; set; }
        public DateTime? SessionDateBegin { get; set; }
        public DateTime? SessionDateEnd { get; set; }
        public decimal? SessionCount { get; set; }
        public decimal PlaceId { get; set; }
        public string PlaceName { get; set; }
        public string PlaceComments { get; set; }
        public decimal PeriodId { get; set; }
        public string PeriodName { get; set; }
        public DateTime? PeriodBegin { get; set; }
        public DateTime? PeriodEnd { get; set; }
        public int? PeriodIsActive { get; set; }
        public decimal WayId { get; set; }
        public string WayName { get; set; }

    }
}
