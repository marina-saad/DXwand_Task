using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DXwand.Entities;

namespace DXwand.Containers
{
    public class dbContainer : DbContext
    {
        public dbContainer(DbContextOptions <dbContainer> op):base(op)
        {

        }

        public DbSet<RMessage> RMessages { get; set; }
        public DbSet<UMessage> UMessages { get; set; }
    }
}
