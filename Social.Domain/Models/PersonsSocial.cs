using System;
using System.Collections.Generic;

namespace Shop.Domain.Models
{
    public  class PersonsSocial
    {
        public PersonsSocial()
        {
            PersonsSocialDoc = new HashSet<PersonsSocialDoc>();
            PersonsSocialLegalRepresentIdLegalRepresentNavigation = new HashSet<PersonsSocialLegalRepresent>();
            PersonsSocialLegalRepresentIdPersonNavigation = new HashSet<PersonsSocialLegalRepresent>();
            PersonsSocialRepresentIdPersonNavigation = new HashSet<PersonsSocialRepresent>();
            PersonsSocialRepresentIdRepresentNavigation = new HashSet<PersonsSocialRepresent>();
            ServisesSocialIdCurrLegalRepresentNavigation = new HashSet<ServisesSocial>();
            ServisesSocialIdCurrRepresentNavigation = new HashSet<ServisesSocial>();
            ServisesSocialPerson = new HashSet<ServisesSocial>();
        }

        /// <summary>
        /// Код записи (первичный ключ)
        /// </summary>
        public decimal PersonId { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        public string Patronymic { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime? Bdate { get; set; }

        /// <summary>
        /// Пол. 1-мужской, 2-женский
        /// </summary>
        public int? Sex { get; set; }

        /// <summary>
        /// Гражданство(страна)
        /// </summary>
        public decimal CountryId { get; set; }

        /// <summary>
        /// Код адреса места жительства из справочника
        /// </summary>
        public decimal? AddressId { get; set; }

        /// <summary>
        /// Квартира
        /// </summary>
        public string Apartment { get; set; }

        /// <summary>
        /// Телефон домашний
        /// </summary>
        public string PhoneHome { get; set; }

        /// <summary>
        /// Телефон рабочий
        /// </summary>
        public string PhoneWork { get; set; }

        /// <summary>
        /// Телефон мобильный
        /// </summary>
        public string PhoneMobile { get; set; }

        /// <summary>
        /// Страховой номер индивидуального лицевого счета (пенсионный фонд)
        /// </summary>
        public string Snils { get; set; }

        /// <summary>
        /// Дата/время создания записи
        /// </summary>
        public DateTime? DateInsert { get; set; }

        /// <summary>
        /// Дата/время последней редакции записи
        /// </summary>
        public DateTime? DateUpdate { get; set; }

        /// <summary>
        /// Код пользователя, редактировавший запись последним
        /// </summary>
        public decimal? IdUser { get; set; }

        public decimal Version { get; set; }

        /// <summary>
        /// Заполняется, если в ЕСС адрес не найден
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 0 - заявитель, 1 - представитель
        /// </summary>
        public decimal? IsRepresent { get; set; }

        /// <summary>
        /// Дата смерти
        /// </summary>
        public DateTime? Ddate { get; set; }

        /// <summary>
        /// Дата акта о смерти
        /// </summary>
        public DateTime? Adate { get; set; }

        /// <summary>
        /// Номер акта о смерти
        /// </summary>
        public string Anum { get; set; }

        /// <summary>
        /// 0 - заявитель, 1 - законный представитель
        /// </summary>
        public decimal? IsLegalRepresent { get; set; }

        /// <summary>
        /// Место работы
        /// </summary>
        public decimal? WorkId { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public decimal? PostId { get; set; }

        /// <summary>
        /// Адрес электронной почты
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Место рождения
        /// </summary>
        public string Birthplace { get; set; }

        public ICollection<PersonsSocialDoc> PersonsSocialDoc { get; set; }
        public ICollection<PersonsSocialLegalRepresent> PersonsSocialLegalRepresentIdLegalRepresentNavigation { get; set; }
        public ICollection<PersonsSocialLegalRepresent> PersonsSocialLegalRepresentIdPersonNavigation { get; set; }
        public ICollection<PersonsSocialRepresent> PersonsSocialRepresentIdPersonNavigation { get; set; }
        public ICollection<PersonsSocialRepresent> PersonsSocialRepresentIdRepresentNavigation { get; set; }
        public ICollection<ServisesSocial> ServisesSocialIdCurrLegalRepresentNavigation { get; set; }
        public ICollection<ServisesSocial> ServisesSocialIdCurrRepresentNavigation { get; set; }
        public ICollection<ServisesSocial> ServisesSocialPerson { get; set; }
    }
}
