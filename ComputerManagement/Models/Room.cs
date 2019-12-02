using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ComputerManagement.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string LongName { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
