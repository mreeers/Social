using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Social.Domain.Models
{
    public partial class JournalInterdepartServSocia
    {
        public decimal Id { get; set; }

        /// <summary>
        /// Журнал межведомственных запросов на каникулярный отдых
        /// </summary>
        public decimal IdJiRest { get; set; }

        /// <summary>
        /// Услуга
        /// </summary>
        public decimal IdService { get; set; }

        public decimal Version { get; set; }

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
        public decimal IdUser { get; set; }

        /// <summary>
        /// Текущее "общее" состояние запроса по данной услуге. 0-сформирован, 1-обрабатывается, 2-обработан, 3-исключен, 4-включен в журнал, 5-не включен в журнал
        /// </summary>
        public int? InterdepartStatus { get; set; }

        /// <summary>
        /// Дата завершения обработки всех запросов по данной услуге
        /// </summary>
        public DateTime? DateFinished { get; set; }

        /// <summary>
        /// Флаг получения результата в ФМС  (0 - нет регистрации , 1 - есть регистрация)
        /// </summary>
        public int? FlagFms { get; set; }

        /// <summary>
        /// Фамилия, по которой осущ. поиск в базе ведомства
        /// </summary>
        public string PersonFm { get; set; }

        /// <summary>
        /// Имя, по которому осущ. поиск в базе ведомства
        /// </summary>
        public string PersonIm { get; set; }

        /// <summary>
        /// Отчество, по которому осущ. поиск в базе ведомства
        /// </summary>
        public string PersonOt { get; set; }

        /// <summary>
        /// Дата рождения, по которой осущ. поиск в базе ведомства
        /// </summary>
        public DateTime? PersonDr { get; set; }

        /// <summary>
        /// Место рождения
        /// </summary>
        public string PersonBplace { get; set; }

        public JournalInterdepartSocial IdJiRestNavigation { get; set; }
        public ServisesSocial IdServiceNavigation { get; set; }
    }
}
