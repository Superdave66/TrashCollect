using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Employee
    {
        [Key]
        public  string Id { get; set; }
        public int ZipCode { get; set; }
        [ForeignKey("Userid")]
        public string Userid { get; set; }
    }
}