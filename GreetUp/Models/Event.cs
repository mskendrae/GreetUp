using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GreetUp.Models
{
    public class Event
    {
        [Key]
        public string Title { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }
        public string description { get; set; }
        public int Going { get; set; }
      
    }
}