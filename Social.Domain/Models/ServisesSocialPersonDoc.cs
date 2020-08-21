using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Domain.Models
{
    public partial class ServisesSocialPersonDoc
    {
        public decimal Id { get; set; }

        /// <summary>
        /// Код услуги
        /// </summary>
        public decimal? ServisesId { get; set; }

        /// <summary>
        /// Код документа
        /// </summary>
        public decimal? PersonsDocId { get; set; }

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
        /// Служебное поле
        /// </summary>
        public decimal Version { get; set; }

        public decimal? IdTypeDoc { get; set; }

        public ServisesSocial Servises { get; set; }
    }
}
