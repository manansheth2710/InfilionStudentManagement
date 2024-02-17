using InfilionStudentManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace InfilionStudentManagement.Models;

public partial class SchoolDbContext : DbContext
{

    public SchoolDbContext(
    DbContextOptions options) : base(options)
    {
    }

    public virtual DbSet<TblStudents> TblStudents { get; set; }
    public virtual DbSet<TblClasses> Classes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Server=ASUS-TUF-FX504G; Database=SchoolDb; user Id=sa; password=sa@123;TrustServerCertificate=True; Trusted_Connection = true; Connection Timeout=900; MultipleActiveResultSets=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
