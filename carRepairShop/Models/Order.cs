using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace carRepairShop.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public string State { get; set; }
        public DateTime Date { get; set; }
        public int TotalPrice { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }

        public int SparePartId { get; set; }
        public SparePart SparePart { get; set; }

        public int StaffId { get; set; }
        public ServiceStaff ServiceStaff { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
