using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Domain.Models
{
    public partial class JournalInterdepartSocial
    {
        public JournalInterdepartSocial()
        {
            JournalInterdepartServSocia = new HashSet<JournalInterdepartServSocia>();
        }

        public decimal Id { get; set; }

        /// <summary>
        /// Дата формирования журнала
        /// </summary>
        public DateTime DateCreate { get; set; }

        /// <summary>
        /// Номер журнала
        /// </summary>
        public decimal? JournalNumber { get; set; }

        /// <summary>
        /// Состояние журнала (0 - сформирован, 1 - обрабатывается, 3 - закрыт/утвержден)
        /// </summary>
        public int JournalStatus { get; set; }

        /// <summary>
        /// Код пользователя, редактировавший запись последним
        /// </summary>
        public decimal IdUser { get; set; }

        /// <summary>
        /// Дата/время создания записи
        /// </summary>
        public DateTime DateInsert { get; set; }

        /// <summary>
        /// Дата/время последней редакции записи
        /// </summary>
        public DateTime DateUpdate { get; set; }

        public decimal Version { get; set; }

        /// <summary>
        /// Дата завершения обработки журнала
        /// </summary>
        public DateTime? DateFinished { get; set; }

        /// <summary>
        /// Минимальная дата регистрации заявления на услугу попавшая в этот журнал
        /// </summary>
        public DateTime? MinDocDate { get; set; }

        /// <summary>
        /// Максимальная дата регистрации заявления на услугу попавшая в этот журнал
        /// </summary>
        public DateTime? MaxDocDate { get; set; }

        /// <summary>
        /// Количество записей(услуг)
        /// </summary>
        public decimal? ServiesCount { get; set; }

        public ICollection<JournalInterdepartServSocia> JournalInterdepartServSocia { get; set; }
    }
}
