using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MODELS.MODELS
{
    public partial class teoryBContext : DbContext
    {
        public teoryBContext()
        {
        }

        public teoryBContext(DbContextOptions<teoryBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Tamrurim> Tamrurim { get; set; }
        public virtual DbSet<alluser> alluser { get; set; }
        public virtual DbSet<questionArr> questionArr { get; set; }
        public virtual DbSet<sabjekTamrurim> sabjekTamrurim { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-J00TKQ5;\n  Initial Catalog=teoryB;Integrated Security=SSPI;\n Trusted_Connection=True;\n  ");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hebrew_CI_AS");

            modelBuilder.Entity<Tamrurim>(entity =>
            {
                entity.HasKey(e => e.i)
                    .HasName("PK__Tamrurim__3BD01996E6D49FF4");

                entity.Property(e => e.i).ValueGeneratedNever();

                entity.Property(e => e.Smol_T_img)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.description)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<alluser>(entity =>
            {
                entity.HasKey(e => e.mail)
                    .HasName("PK__alluser__7A21290536A24186");

                entity.Property(e => e.mail)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.addres)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.password)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.phon)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<questionArr>(entity =>
            {
                entity.Property(e => e.id).ValueGeneratedNever();

                entity.Property(e => e.e1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.e2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.e3)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.e4)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.img)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.question)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<sabjekTamrurim>(entity =>
            {
                entity.Property(e => e.id).ValueGeneratedNever();

                entity.Property(e => e.T_img)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.namee)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
