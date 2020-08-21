using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Domain.Models
{
    public partial class ServisesSocialHistorys
    {
        public ServisesSocialHistorys()
        {
            ServisesSocial = new HashSet<ServisesSocial>();
        }

        /// <summary>
        /// Уникальный код
        /// </summary>
        public decimal Id { get; set; }

        /// <summary>
        /// Код услуги
        /// </summary>
        public decimal ServisesId { get; set; }

        /// <summary>
        /// Описание изменения
        /// </summary>
        public string HistoryText { get; set; }

        /// <summary>
        /// Дата изменения
        /// </summary>
        public DateTime HistoryDate { get; set; }

        /// <summary>
        /// Пользователь
        /// </summary>
        public decimal? IdUser { get; set; }

        /// <summary>
        /// Состояние
        /// </summary>
        public decimal? IdStatus { get; set; }

        public decimal? IdTypeFailure { get; set; }


        public ServisesSocial Servises { get; set; }
        public ICollection<ServisesSocial> ServisesSocial { get; set; }
    }
}
