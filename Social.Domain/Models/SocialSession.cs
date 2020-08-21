using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Shop.Domain.Models
{
    public partial class SocialSession
    {
        public SocialSession()
        {
            EventSocialSession = new HashSet<EventSocialSession>();
            ServisesSocial = new HashSet<ServisesSocial>();
            SocialDelivery = new HashSet<SocialDelivery>();
        }

        /// <summary>
        /// Уникальный ключ
        /// </summary>
        [DisplayFormat(DataFormatString = ("{0:0.##}"))]
        public decimal Id { get; set; }

        /// <summary>
        /// Место отдыха
        /// </summary>
        public decimal SocialPlaceId { get; set; }

        /// <summary>
        /// Номер смены
        /// </summary>
        [DisplayFormat(DataFormatString = ("{0:0.##}"))]
        public decimal NumSession { get; set; }

        /// <summary>
        /// Дата начала смены
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime? DateBegin { get; set; }

        /// <summary>
        /// Дата окончания смены
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime? DateEnd { get; set; }

        /// <summary>
        /// Комментарий к условиям смены
        /// </summary>
        public string Comments { get; set; }

        /// <summary>
        /// Количество путевок
        /// </summary>
        [DisplayFormat(DataFormatString = ("{0:0.##}"))]
        public decimal? Count { get; set; }

        /// <summary>
        /// Дата добавления записи
        /// </summary>
        public DateTime? DateInsert { get; set; }

        /// <summary>
        /// Дата последнего редактирования записи
        /// </summary>
        public DateTime? DateUpdate { get; set; }

        public decimal? Version { get; set; }

        /// <summary>
        /// Код пользователя, редактировавший запись последним
        /// </summary>
        public decimal? IdUser { get; set; }

        /// <summary>
        /// Текущее событие
        /// </summary>
        public decimal? IdEventSession { get; set; }

        public EventSocialSession IdEventSessionNavigation { get; set; }
        public SocialPlace SocialPlace { get; set; }
        public ICollection<EventSocialSession> EventSocialSession { get; set; }
        public ICollection<ServisesSocial> ServisesSocial { get; set; }
        public ICollection<SocialDelivery> SocialDelivery { get; set; }

        public static implicit operator List<object>(SocialSession v)
        {
            throw new NotImplementedException();
        }
    }
}
