using SuperFancyHotel.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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

        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = false)]
        public DateTime DateAvailable { get; set; }

    }
}
