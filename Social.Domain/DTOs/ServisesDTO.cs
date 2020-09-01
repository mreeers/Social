using System;
using System.Collections.Generic;
using System.Text;

namespace Social.Domain.DTOs
{
    public class ServisesDTO
    {
        /// <summary>
        /// Код услуги(первичный ключ)
        /// </summary>
        public decimal Id { get; set; }

        /// <summary>
        /// Уникальный код заявителя
        /// </summary>
        public decimal? PersonId { get; set; }

        /// <summary>
        /// Категория заявителя
        /// </summary>
        public decimal? CategoryId { get; set; } = 3;

        /// <summary>
        /// Дата регистрации услуги (дата документа)
        /// </summary>
        public DateTime? DateReg { get; set; }

        /// <summary>
        /// Номер документа
        /// </summary>
        public string DocNum { get; set; }

        /// <summary>
        /// Смена
        /// </summary>
        public decimal? SessionId { get; set; }

        /// <summary>
        /// Способ доставки (0 - авиа, 1 - ж/д, 2 - автобус, 3 - самодоставка)
        /// </summary>
        public int? Delivery { get; set; }

        /// <summary>
        /// Текущее состояние жизненного цикла услуги
        /// </summary>
        public decimal? IdServiceHistorys { get; set; }

        /// <summary>
        /// Текущий законный представитель
        /// </summary>
        public decimal? IdCurrLegalRepresent { get; set; }

        /// <summary>
        /// Оператор, создавший услугу (для прав на записи)
        /// </summary>
        public decimal? IdOperInsert { get; set; } = 1;

        /// <summary>
        /// Контроллёр, изменивший состояние услуги (для прав на записи)
        /// </summary>
        public decimal? IdContrUpdate { get; set; }

        public decimal Version { get; set; } = 1;
        public decimal? SchoolId { get; set; } = 98;

        /// <summary>
        /// Текущий представитель
        /// </summary>
        public decimal? IdCurrRepresent { get; set; }


        //public string InfoIpAdress { get; set; }
        //public string InfoBrowser { get; set; }
    }
}
