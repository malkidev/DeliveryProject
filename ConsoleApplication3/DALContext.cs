using BE;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALContext : DbContext
    {
      public DbSet<Client> ClientList { get; set; }
      public DbSet<DeliveryMen> DeliveryMenList { get; set; }
      public DbSet<Distribution> DistributionList { get; set; }

        
    }
}
