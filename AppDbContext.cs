using Microsoft.EntityFrameworkCore;

namespace WinFormsApp5
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               "Server=(localdb)\\mssqllocaldb;Database=QuanLySinhVien;Trusted_Connection=True;TrustServerCertificate=True;"
            );
        }
    }
}
