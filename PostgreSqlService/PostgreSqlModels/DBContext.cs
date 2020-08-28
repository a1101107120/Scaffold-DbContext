using Microsoft.EntityFrameworkCore;

namespace PostgreSqlService.PostgreSqlModels
{
    public partial class DBContext : DbContext
    {
        public DBContext()
        {
        }

        public DBContext(DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseNpgsql("Host=localhost; Port=5432 ;Database=NICKTEST;Username=postgres;Password=a123456");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.UserInfoId)
                    .HasName("fki_UserInfo_Fk");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Account).HasColumnType("character varying");

                entity.Property(e => e.Password).HasColumnType("character varying");

                entity.HasOne(d => d.UserInfo)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserInfoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("UserInfo_Fk");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Birthday).HasColumnType("date");

                entity.Property(e => e.Name).HasColumnType("character varying");
            });
        }
    }
}
