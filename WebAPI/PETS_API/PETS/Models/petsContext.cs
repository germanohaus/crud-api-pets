using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PETS.Models
{
    public partial class petsContext : DbContext
    {
        /*
         * public petsContext()
        {
        }
        */
        public petsContext(DbContextOptions<petsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cats> Cats { get; set; }
        public virtual DbSet<Dogs> Dogs { get; set; }
        public virtual DbSet<Owner> Owner { get; set; }

        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=GGPC;Initial Catalog=pets;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }
        */

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cats>(entity =>
            {
                entity.ToTable("cats");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Ownerid).HasColumnName("ownerid");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Cats)
                    .HasForeignKey(d => d.Ownerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cats_ownerid");
            });

            modelBuilder.Entity<Dogs>(entity =>
            {
                entity.ToTable("dogs");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Age).HasColumnName("age");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Ownerid).HasColumnName("ownerid");

                entity.HasOne(d => d.Owner)
                    .WithMany(p => p.Dogs)
                    .HasForeignKey(d => d.Ownerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_dogs_ownerid");
            });

            modelBuilder.Entity<Owner>(entity =>
            {
                entity.ToTable("owner");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
