using System;
using System.Collections.Generic;
using System.Text;

namespace Social.Domain.Models
{
    public class TypeDoc
    {
        public decimal Id { get; set; }
        public string TypeDocName { get; set; }
        public string CorporateCode { get; set; }
        public decimal? Parent { get; set; }
        public decimal HasChild { get; set; }
        public decimal Version { get; set; }
        public decimal IdUser { get; set; }
        public DateTime DateInsert { get; set; }
        public DateTime DateUpdate { get; set; }
        public string TypeDocNameRest { get; set; }
        public decimal? Ord { get; set; }
    }
}
