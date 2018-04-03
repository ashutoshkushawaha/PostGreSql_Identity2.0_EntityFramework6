using Microsoft.AspNet.Identity.EntityFramework;
using PostGreSql.Models.Table;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PostGreSql.Models.Context
{
    public class SampleDbContext: IdentityDbContext<ApplicationUser>
    {
        public SampleDbContext() : base("Conn")
        {
            Database.SetInitializer<SampleDbContext>(null);
        }
        public virtual DbSet<sys_user> SYS_USER { get; set; }
        public virtual DbSet<company> Company { get; set; }
        public static SampleDbContext Create()
        {
            return new SampleDbContext();
        }
    }
}