using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Domain.Models
{
    public partial class EventSocialSession
    {
        public EventSocialSession()
        {
            SocialSession = new HashSet<SocialSession>();
        }

        public decimal Id { get; set; }

        /// <summary>
        /// Смена
        /// </summary>
        public decimal SessionId { get; set; }

        /// <summary>
        /// Событие: 0 - формирование, 1 - сформирован, 2 - утверждён, 3 - изменён, 4 - архив, 5 - ошибка
        /// </summary>
        public decimal Event { get; set; }

        /// <summary>
        /// Дата/время создания записи
        /// </summary>
        public DateTime DateInsert { get; set; }

        /// <summary>
        /// Дата/время последней редакции записи
        /// </summary>
        public DateTime DateUpdate { get; set; }

        /// <summary>
        /// Код пользователя, редактировавший запись последним
        /// </summary>
        public decimal IdUser { get; set; }

        public decimal Version { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        public string Note { get; set; }

        public SocialSession Session { get; set; }
        public ICollection<SocialSession> SocialSession { get; set; }
    }
}
