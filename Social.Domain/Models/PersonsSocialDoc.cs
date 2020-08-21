using System;
using System.Collections.Generic;

namespace Social.Domain.Models
{
    public class PersonsSocialDoc
    {
        public PersonsSocialDoc()
        {
            PersonsSocialDocFile = new HashSet<PersonsSocialDocFile>();
        }

        /// <summary>
        /// Код документа
        /// </summary>
        public decimal Id { get; set; }

        /// <summary>
        /// Тип документа
        /// </summary>
        public decimal? TypeDocId { get; set; }

        /// <summary>
        /// Код заявителя
        /// </summary>
        public decimal? PersonId { get; set; }

        /// <summary>
        /// Версия документа
        /// </summary>
        public decimal VersionDoc { get; set; }

        /// <summary>
        /// Серия документа
        /// </summary>
        public string Ser { get; set; }

        /// <summary>
        /// Номер документа
        /// </summary>
        public string Num { get; set; }

        /// <summary>
        /// Кем выдан документ
        /// </summary>
        public string Get { get; set; }

        /// <summary>
        /// Когда выдан документ
        /// </summary>
        public DateTime? GetDate { get; set; }

        /// <summary>
        /// Дата/время создания записи
        /// </summary>
        public DateTime DateInsert { get; set; }

        /// <summary>
        /// Дата/время последней редакции записи
        /// </summary>
        public DateTime DateUpdate { get; set; }

        /// <summary>
        /// Код пользователя, редактировавший запись последним
        /// </summary>
        public decimal? IdUser { get; set; }

        /// <summary>
        /// Количество листов в документе
        /// </summary>
        public decimal NumSheet { get; set; }

        public decimal Version { get; set; }

        /// <summary>
        /// Используется для: Дата увольнения(TYPE_DOC=9), Дата окончания обучения(TYPE_DOC=13)
        /// </summary>
        public DateTime? DateOut { get; set; }

        /// <summary>
        /// Используется для: Дата принятия на работу(TYPE_DOC=9), Дата начала обучения(TYPE_DOC=13)
        /// </summary>
        public DateTime? DateIn { get; set; }

        /// <summary>
        /// Дата рождения (используется для документов с типом - Свидетельство о рождении)
        /// </summary>
        public DateTime? Bdate { get; set; }

        public string Guid { get; set; }

        public PersonsSocial Person { get; set; }
        public ICollection<PersonsSocialDocFile> PersonsSocialDocFile { get; set; }
    }
}
