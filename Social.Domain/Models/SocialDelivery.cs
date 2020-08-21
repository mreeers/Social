using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social.Domain.Models
{
    public partial class SocialDelivery
    {
        /// <summary>
        /// Уникальный ключ
        /// </summary>
        public decimal Id { get; set; }

        /// <summary>
        /// Смена
        /// </summary>
        public decimal? SocialSessionId { get; set; }

        public int? Method { get; set; }

        /// <summary>
        /// Дата добавления записи
        /// </summary>
        public DateTime? DateInsert { get; set; }

        /// <summary>
        /// Дата последнего редактирования записи
        /// </summary>
        public DateTime? DateUpdate { get; set; }

        public decimal? Version { get; set; }

        public decimal? IdUser { get; set; }

        public SocialSession SocialSession { get; set; }
    }
}
