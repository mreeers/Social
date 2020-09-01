using System;
using System.Collections.Generic;
using System.Text;

namespace Social.Domain.DTOs
{
    public class RepresentDTO
    {
        public decimal PersonId { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string SurnameRepresent { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string NameRepresent { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string PatronymicRepresent { get; set; }

        /// <summary>
        /// Телефон домашний
        /// </summary>
        public string PhoneHome { get; set; }

        /// <summary>
        /// Телефон рабочий
        /// </summary>
        public string PhoneWork { get; set; } = "+7(444) 444-44-44";

        /// <summary>
        /// Телефон мобильный
        /// </summary>
        public string PhoneMobile { get; set; }

        /// <summary>
        /// Место работы
        /// </summary>
        public decimal? WorkId { get; set; } = 10009935243;

        /// <summary>
        /// Адрес электронной почты
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 0 - заявитель, 1 - законный представитель
        /// </summary>
        public decimal? IsLegalRepresent { get; set; } = 0;

        /// <summary>
        /// Код пользователя, редактировавший запись последним
        /// </summary>
        public decimal? IdUser { get; set; } = 1;
    }
}
