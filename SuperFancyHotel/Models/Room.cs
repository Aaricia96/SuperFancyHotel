using SuperFancyHotel.Enum;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SuperFancyHotel.Models
{
    public class Room
    {
        [Key]
        public long Id { get; set; }

        public string Name { get; set; }

        public bool Available { get; set; }

        public ERoomType Type { get; set; }

        public ERoomSize Size { get; set; }
        
        [Display(Name = "Room available from")]
        [DataType(DataType.Date)]
        public DateTime DateAvailable { get; set; }

        public IList<Booking> Booking { get; set; }
    }
}
