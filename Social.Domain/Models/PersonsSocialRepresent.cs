using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Domain.Models
{
    public partial class PersonsSocialRepresent
    {
        public decimal Id { get; set; }

        /// <summary>
        /// Представитель (is_represent = 1)
        /// </summary>
        public decimal IdRepresent { get; set; }

        /// <summary>
        /// Заявитель (is_represent = 0)
        /// </summary>
        public decimal IdPerson { get; set; }

        public DateTime DateInsert { get; set; }

        public DateTime DateUpdate { get; set; }

        public decimal IdUser { get; set; }

        public decimal Version { get; set; }

        public PersonsSocial IdPersonNavigation { get; set; }
        public PersonsSocial IdRepresentNavigation { get; set; }
    }
}
