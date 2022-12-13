using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace carRepairShop.Models
{
    public class Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ServiceId { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Duration { get; set; }

        public List<Order> Orders { get; set; }
    }
}
