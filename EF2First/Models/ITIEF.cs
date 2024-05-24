using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace EF2First.Models
{
   public class ITIEF:DbContext
    {
        public virtual DbSet<Catalog> catalog { get; set; }

        public virtual DbSet<Author> author { get; set; }
        public virtual DbSet<New> News { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=.;Database=ITIPD;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Author>().Property(a => a.Joindate).HasColumnType("date");
        }
    }
}
