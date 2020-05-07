using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BasicCrud.Models
{
    public partial class dbContext : DbContext
    {
        public dbContext()
        {
        }

        public dbContext(DbContextOptions<dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TbUser> TbUser { get; set; }
               
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TbUser>(entity =>
            {
                entity.ToTable("tb_user");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DsEmail)
                    .IsRequired()
                    .HasColumnName("ds_email")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NmName)
                    .IsRequired()
                    .HasColumnName("nm_name")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
