using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Group1_A2.Models
{
    public class Business
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        // Add data annotation
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public Category Category { get; set; }
        public string Website { get; set; }
        public string Owner { get; set; }
        public decimal Rating { get; set; }

    }
}