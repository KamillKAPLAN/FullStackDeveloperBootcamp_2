using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BootcampAPI.DbFirstExx
{
    public partial class BootcampDbContext : DbContext
    {
        public BootcampDbContext()
        {
        }

        public BootcampDbContext(DbContextOptions<BootcampDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Grade> Grades { get; set; } = null!;
        public virtual DbSet<Standard> Standards { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=KKAPLAN;Database=BootcampDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasIndex(e => e.GradeId, "IX_Students_GradeId");

                entity.HasIndex(e => e.StandardId, "IX_Students_StandardId");

                entity.Property(e => e.Height).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.GradeId);

                entity.HasOne(d => d.Standard)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.StandardId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
