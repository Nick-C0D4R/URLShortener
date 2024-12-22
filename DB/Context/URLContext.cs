using DB.Connector;
using DB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Context
{
    public class URLContext : DbContext
    {
        public DbSet<URLInfo> URLs { get; set; }
        public DbSet<UserInfo> Users { get; set; }

        public URLContext() : base()
        {
            DBConnector.CreateDB("C:\\Users\\Mykola\\source\\repos\\URLShortener\\DB");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
