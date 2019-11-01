using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastNAme { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public DayOfWeek PickUpDates { get; set; }
        public  double? Balance { get; set; }
        public double? Monthlycharge { get; set; }
        public bool? PickupConfirmed { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public DateTime? ExtraPickup {get; set;}
       [ForeignKey("Userid")]
       public string Userid { get; set; }


    }

}