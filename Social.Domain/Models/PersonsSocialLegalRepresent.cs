using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Domain.Models
{
    public partial class PersonsSocialLegalRepresent
    {
        public decimal Id { get; set; }

        /// <summary>
        /// Законный представитель (is_legal_represent = 1)
        /// </summary>
        public decimal IdLegalRepresent { get; set; }

        /// <summary>
        /// Заявитель (is_legal_represent = 0)
        /// </summary>
        public decimal IdPerson { get; set; }

        public DateTime DateInsert { get; set; }

        public DateTime DateUpdate { get; set; }

        public decimal IdUser { get; set; }

        public decimal Version { get; set; }

        public PersonsSocial IdLegalRepresentNavigation { get; set; }
        public PersonsSocial IdPersonNavigation { get; set; }
    }
}
