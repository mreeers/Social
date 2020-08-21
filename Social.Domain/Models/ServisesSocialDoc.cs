using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Domain.Models
{
    public partial class ServisesSocialDoc
    {
        /// <summary>
        /// Уникальный код
        /// </summary>
        public decimal Id { get; set; }

        /// <summary>
        /// Код усулуги
        /// </summary>
        public decimal ServisesId { get; set; }

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
        /// Расширение файла
        /// </summary>
        public string Extension { get; set; }

        /// <summary>
        /// Примечание к файлу
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Тело файла
        /// </summary>
        public byte[] FileBody { get; set; }

        /// <summary>
        /// 0 - Заявление, 1 - Расписка в приеме документов, 2 - Уведомление об отказе
        /// </summary>
        public int? TypeServiceDoc { get; set; }

        /// <summary>
        /// Количество листов в документе
        /// </summary>
        public decimal NumSheet { get; set; }

        public ServisesSocial Servises { get; set; }
    }
}
