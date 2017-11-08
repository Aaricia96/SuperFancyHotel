using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperFancyHotel.Models
{
    public class Booking
    {

        [Key]
        public long Id { get; set; }

        [Required]
        [Display(Name = "Start date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "End date")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        public Room Room { get; set; }

        [Required]
        [Display(Name = "Room name")]
        public long RoomId{ get; set; }
        
        public ApplicationUser User { get; set; }

        [Required]
        [Display(Name = "Guest")]
        public string UserId { get; set; } 
    }
}
