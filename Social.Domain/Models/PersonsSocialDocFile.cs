using System;

namespace Social.Domain.Models
{
    public partial class PersonsSocialDocFile
    {
        /// <summary>
        /// Уникальный код
        /// </summary>
        public decimal Id { get; set; }

        /// <summary>
        /// Документ
        /// </summary>
        public decimal? IdPersonsDoc { get; set; }

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

        public decimal Version { get; set; }

        /// <summary>
        /// Имя файла
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Размер файла
        /// </summary>
        public decimal? FileSize { get; set; }

        /// <summary>
        /// Дата создания файла
        /// </summary>
        public DateTime? DateFileCreate { get; set; }

        /// <summary>
        /// Примечание к файлу
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Тело файла
        /// </summary>
        public byte[] FileBody { get; set; }

        public string Guid { get; set; }

        public string Extension { get; set; }

        public PersonsSocialDoc IdPersonsDocNavigation { get; set; }
    }
}
