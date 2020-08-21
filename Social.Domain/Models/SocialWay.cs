using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Domain.Models
{
    public partial class SocialWay
    {
        public SocialWay()
        {
            SocialPlace = new HashSet<SocialPlace>();
        }

        /// <summary>
        /// Уникальный ключ
        /// </summary>
        public decimal Id { get; set; }

        /// <summary>
        /// Период отдыха
        /// </summary>
        public decimal SocialPeriodId { get; set; }

        /// <summary>
        /// Наименование направления
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Признак территории (0-в пределах ХМАО, 1- за пределами ХМАО, в РФ, 2- Загран)
        /// </summary>
        public int? SignTerritory { get; set; }

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

        public SocialPeriod SocialPeriod { get; set; }
        public ICollection<SocialPlace> SocialPlace { get; set; }
    }
}
