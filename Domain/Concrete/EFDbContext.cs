using Car_Agency.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Car_Agency.Domain.Concrete
{
    public class EFDbContext:DbContext
    {
       public DbSet<Car> cars { get; set; }

        public System.Data.Entity.DbSet<Car_Agency.Models.InstallerInfo> InstallerInfoes { get; set; }
    }
}