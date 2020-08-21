using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Social.Domain.DTOs
{
    public class ChildDTO
    {
        /// <summary>
        /// Код записи (первичный ключ)
        /// </summary>
        public decimal PersonId { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        [Display(Name = "Фамилия *")]
        [StringLength(200)]
        [Required]
        public string Surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        [Display(Name = "Имя *")]
        [StringLength(200)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        [Display(Name = "Отчество")]
        [StringLength(200)]
        public string Patronymic { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        [DataType(DataType.Date)]
        [Display(Name = "Дата рождения *")]
        [Required]
        public DateTime? Bdate { get; set; }

        /// <summary>
        /// Пол. 1-мужской, 2-женский
        /// </summary>
        public int? Sex { get; set; } = 1;

        /// <summary>
        /// Место рождения
        /// </summary>
        [MaxLengthAttribute(200)]
        [Display(Name = "Место рождения *")]
        public string Birthplace { get; set; } = "Сургут";
    }
}
