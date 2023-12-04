using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Model.DataModels;

namespace DAL.EF
{
    public class MyDbContext:DbContext
    {
        public virtual DbSet<Gra>? Gry { get; set; }
        public virtual DbSet<Gracz>? Gracze { get; set; }
        public virtual DbSet<Wydawnictwo>? Wydawnictwa { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
