using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Domain.Models
{
    public class ServisesSocial
    {
        public ServisesSocial()
        {
            JournalInterdepartServSocia = new HashSet<JournalInterdepartServSocia>();
            ServisesSocialDoc = new HashSet<ServisesSocialDoc>();
            ServisesSocialFamilyCat = new HashSet<ServisesSocialFamilyCat>();
            ServisesSocialHistorys = new HashSet<ServisesSocialHistorys>();
            ServisesSocialPersonDoc = new HashSet<ServisesSocialPersonDoc>();
        }

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
        public decimal? CategoryId { get; set; }

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
        public decimal? IdOperInsert { get; set; }

        /// <summary>
        /// Контроллёр, изменивший состояние услуги (для прав на записи)
        /// </summary>
        public decimal? IdContrUpdate { get; set; }

        /// <summary>
        /// Номер талона
        /// </summary>
        public string RoomCoupon { get; set; }

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
        /// Школа
        /// </summary>
        public decimal? SchoolId { get; set; }

        /// <summary>
        /// Класс
        /// </summary>
        [MaxLengthAttribute(5)]
        public string Class { get; set; }

        /// <summary>
        /// Текущий представитель
        /// </summary>
        public decimal? IdCurrRepresent { get; set; }

        /// <summary>
        /// Резерв
        /// </summary>
        public decimal? Reserve { get; set; }

        public PersonsSocial IdCurrLegalRepresentNavigation { get; set; }
        public PersonsSocial IdCurrRepresentNavigation { get; set; }
        public ServisesSocialHistorys IdServiceHistorysNavigation { get; set; }
        public PersonsSocial Person { get; set; }
        public SocialSession Session { get; set; }
        public ICollection<JournalInterdepartServSocia> JournalInterdepartServSocia { get; set; }
        public ICollection<ServisesSocialDoc> ServisesSocialDoc { get; set; }
        public ICollection<ServisesSocialFamilyCat> ServisesSocialFamilyCat { get; set; }
        public ICollection<ServisesSocialHistorys> ServisesSocialHistorys { get; set; }
        public ICollection<ServisesSocialPersonDoc> ServisesSocialPersonDoc { get; set; }
    }
}
