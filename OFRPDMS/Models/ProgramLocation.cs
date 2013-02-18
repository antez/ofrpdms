using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OFRPDMS.Models
{
    public class ProgramLocation
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class ProgramLocationDBContext : DbContext
    {
        public DbSet<ProgramLocation> ProgramLocations { get; set; }
    }

}