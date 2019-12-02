using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerManagement.Models
{
    public class Computer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Room { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Specifications { get; set; }
        [Required]
        public int RamSize { get; set; }
        [Required]
        public double DiskSize { get; set; }
        [Required]
        [Display(Name = "Is it broken?")]
        public bool IsBroken { get; set; }
        [Required]
        public int RoomId { get; set; }




    }
}
