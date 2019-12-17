using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Car_Agency.Models
{
    public class Car
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string Model { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }   //store the src="" of Image
        public string Description { get; set; }

    }
}