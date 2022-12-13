using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace carRepairShop.Models
{
    public class CarRepairShopContext: DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SparePart> SpareParts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceManager> ServiceManagers { get; set; }
        public DbSet<ServiceMaster> ServiceMasters { get; set; }
        public DbSet<ServiceStaff> ServiceStaffs { get; set; }

        public CarRepairShopContext(DbContextOptions<CarRepairShopContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}
