using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace carRepairShop.Models
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CarId { get; set; }
        public string LicencePlate { get; set; } 
        public string Mark { get; set; }
        public string Model { get; set; }
        public int YearOfIssue { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        public Order Order { get; set; }
    }
}
