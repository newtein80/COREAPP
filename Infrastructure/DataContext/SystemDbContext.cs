using System;
using ApplicationCore.Entity.SystemModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Infrastructure.DataContext
{
    public partial class SystemDbContext : DbContext
    {
        public SystemDbContext()
        {
        }

        public SystemDbContext(DbContextOptions<SystemDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<T_COMMON_CODE> T_COMMON_CODE { get; set; }
        public virtual DbSet<T_MENU_MASTER> T_MENU_MASTER { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<T_COMMON_CODE>(entity =>
            {
                entity.HasKey(e => new { e.CODE_TYPE, e.CODE_ID });

                entity.Property(e => e.CODE_TYPE).HasMaxLength(32);

                entity.Property(e => e.CODE_ID).HasMaxLength(32);

                entity.Property(e => e.CODE_COMMENT).HasMaxLength(128);

                entity.Property(e => e.CODE_NAME)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.CODE_TYPE_NAME)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.CREATE_DT).HasColumnType("datetime");

                entity.Property(e => e.CREATE_USER_ID).HasMaxLength(16);
            });

            modelBuilder.Entity<T_MENU_MASTER>(entity =>
            {
                entity.HasKey(e => e.MENU_IDENTITY);

                entity.Property(e => e.CREATED_DATE).HasColumnType("datetime");

                entity.Property(e => e.CSS_CLASS).HasMaxLength(64);

                entity.Property(e => e.MENU_ACTION).HasMaxLength(64);

                entity.Property(e => e.MENU_AREA).HasMaxLength(64);

                entity.Property(e => e.MENU_CONTROLLER).HasMaxLength(64);

                entity.Property(e => e.MENU_ID).HasMaxLength(64);

                entity.Property(e => e.MENU_NAME).HasMaxLength(64);

                entity.Property(e => e.PARENT_MENUID).HasMaxLength(64);

                entity.Property(e => e.USER_ROLL).HasMaxLength(450);
            });
        }
    }
}
