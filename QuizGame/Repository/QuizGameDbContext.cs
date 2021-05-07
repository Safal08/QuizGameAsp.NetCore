using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using QuizGame.Repository.Models;

#nullable disable

namespace QuizGame.Repository
{
    public partial class QuizGameDbContext : DbContext
    {
      
        public QuizGameDbContext(DbContextOptions<QuizGameDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<QuizGameTable> QuizGameTables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-KBAPQC1;Initial Catalog=QuizGame;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<QuizGameTable>(entity =>
            {
                entity.HasKey(e => e.Qid)
                    .HasName("PK__QuizGame__CAB64A03BDABA18E");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
