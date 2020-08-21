using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Domain.Models
{
    public partial class SocialPlace
    {
        public SocialPlace()
        {
            SocialSession = new HashSet<SocialSession>();
        }

        /// <summary>
        /// Уникальный ключ
        /// </summary>
        public decimal Id { get; set; }

        /// <summary>
        /// Направление отдыха
        /// </summary>
        public decimal SocialWayId { get; set; }

        /// <summary>
        /// Название места отдыха
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ориентировочная сумма затрат родителей
        /// </summary>
        public string Comments { get; set; }

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

        public SocialWay SocialWay { get; set; }
        public ICollection<SocialSession> SocialSession { get; set; }
    }
}
