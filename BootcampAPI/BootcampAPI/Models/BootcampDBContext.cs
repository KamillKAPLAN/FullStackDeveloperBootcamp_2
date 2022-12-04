using Microsoft.EntityFrameworkCore;

namespace BootcampAPI.Models
{
    public class BootcampDBContext : DbContext
    {
        /*IConfigurationRoot _configuration;
        public BootcampDBContext()
        {
            var config = new ConfigurationBuilder()
              .AddJsonFile("appsettings.json")
              .AddJsonFile("appsettings.Development.json", true);
            _configuration = config.Build();
        }*/
        public BootcampDBContext(DbContextOptions<BootcampDBContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                // optionsBuilder.UseSqlServer("Server=DESKTOP-V3D3OKC;Database=BootcampDb;User Id=sa;Password=1;");
                optionsBuilder.UseSqlServer(_configuration.GetSection("SqlConnectionString").Get<string>());
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Fluent API
            modelBuilder.HasDefaultSchema("Boot");

            modelBuilder.Entity<Student>().ToTable("StudentInfo");
            modelBuilder.Entity<Student>().ToTable("StudentInfo", "FullStack");

            modelBuilder.Entity<Standard>().HasKey(s => s.Key);
            modelBuilder.Entity<Student>().Property(p => p.BirthDate).HasColumnName("DoB").HasColumnOrder(3).HasColumnType("datetime2");
            modelBuilder.Entity<Student>().Property(p => p.Height).IsRequired();
            modelBuilder.Entity<Student>().Property(p => p.Name).HasMaxLength(30);
        }
    }
}
