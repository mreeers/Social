using System;
using System.Collections.Generic;
using System.Text;

namespace Social.Domain.Models
{
    public class School
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string AbbName { get; set; }
        public DateTime DateInsert { get; set; }
        public DateTime DateUpdate { get; set; }
        public decimal IdUser { get; set; }
        public decimal Version { get; set; }
    }
}
