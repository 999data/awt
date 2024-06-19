using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationMVC.Models
{
    public class Customer
    {
        [Required]
        public int CustID { get; set; }
        [Required]
        public string custName { get; set; }
        [Range(10,100)]
        public string custAge { get; set; }
    }
}