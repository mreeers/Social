using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Domain.Models
{
    public partial class ServisesSocialFamilyCat
    {
        /// <summary>
        /// Уникальный код
        /// </summary>
        public decimal Id { get; set; }

        /// <summary>
        /// Код услуги
        /// </summary>
        public decimal ServisesSocialId { get; set; }

        /// <summary>
        /// Код категории
        /// </summary>
        public decimal CategoryFamilyId { get; set; }

        /// <summary>
        /// Номер некоторого документа подтверждающий категорию
        /// </summary>
        public string NumAttribute { get; set; }

        /// <summary>
        /// Дата некоторого документа подтверждающий категорию
        /// </summary>
        public DateTime? DateAttribute { get; set; }

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

        public ServisesSocial ServisesSocial { get; set; }
    }
}
