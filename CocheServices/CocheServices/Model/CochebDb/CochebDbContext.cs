using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CocheServices.Model.CochebDb
{
    public partial class CochebDbContext : DbContext
    {
        public CochebDbContext()
        {
        }

        public CochebDbContext(DbContextOptions<CochebDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TCoche> TCoche { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=JOSE\\SQLEXPRESS; Initial Catalog = coche; Integrated Security = True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TCoche>(entity =>
            {
                entity.Property(e => e.CocheId).ValueGeneratedNever();

                entity.Property(e => e.CocheColor).IsUnicode(false);

                entity.Property(e => e.CocheFull).IsUnicode(false);

                entity.Property(e => e.CocheMarca).IsUnicode(false);

                entity.Property(e => e.CocheMec).IsUnicode(false);

                entity.Property(e => e.CochePlaca).IsUnicode(false);
            });
        }
    }
}
