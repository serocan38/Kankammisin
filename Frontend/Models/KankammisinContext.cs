using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Frontend.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Frontend.Models
{
    public class KankammisinContext : DbContext
    {
        public KankammisinContext(DbContextOptions<KankammisinContext> options)
            : base(options)
        {
        }
        public DbSet<TestModel> Testler { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<SoruModel> Sorular { get; set; }
        public DbSet<IstatistikModel> Istatistik { get; set; }
        private EntityQueryable<TestModel> BosLinkSil { get; set; }
        public DbSet<CozulenTestModel> CozulenTest { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }


}
