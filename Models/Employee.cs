using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Employee
    {
        [key]
        public  string Id { get; set; }
        public int ZipCode { get; set; }
    }
}