using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social.Domain.Models
{
    public partial class SocialPeriod
    {
        public SocialPeriod()
        {
            SocialWay = new HashSet<SocialWay>();
        }

        /// <summary>
        /// Уникальный ключ
        /// </summary>
        public decimal Id { get; set; }

        /// <summary>
        /// Наименование периода
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Начало периода отдыха детей
        /// </summary>
        public DateTime? PeriodBegin { get; set; }

        /// <summary>
        /// Конец периода отдыха детей
        /// </summary>
        public DateTime? PeriodEnd { get; set; }

        /// <summary>
        /// Начало предоставления услуги(приема документов) на этот период
        /// </summary>
        public DateTime? GetDocBegin { get; set; }

        /// <summary>
        /// Конец предоставления услуги(приема документов) на этот период
        /// </summary>
        public DateTime? GetDocEnd { get; set; }

        /// <summary>
        /// Признак актуальности (0 - действующая, 1 - архив)
        /// </summary>
        public int? IsActive { get; set; }

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

        public ICollection<SocialWay> SocialWay { get; set; }
    }
}
