using Microsoft.EntityFrameworkCore;
using PageBE.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PageBE.DataModel
{
    public class DataContext:DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions options): base(options) 
        { 
        }
        public virtual DbSet<StatusStudenta> statusStudentas { get; set; }
        public virtual DbSet<Studenti> Studentis { get; set; }
        public virtual DbSet<Kurs> Kurs { get; set; }
        public virtual DbSet<KursStudenta> KursStudentas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=PageDB1;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedStatusa();
            modelBuilder.SeedStudenta();
            modelBuilder.SeedKurs();
            modelBuilder.SeedKursStudenta();
        }
    }
}
