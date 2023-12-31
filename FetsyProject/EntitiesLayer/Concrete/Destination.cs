﻿using System.ComponentModel.DataAnnotations;

namespace EntitiesLayer.Concrete
{
    public class Destination
    {
        [Key]
        public int DestinationId { get; set; }
        public string City  { get; set; }
        public string DayNight { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public int Capacity  { get; set; }
        public bool Status { get; set; }

    }



}
