using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Inscricoes.Data.Models;

namespace Inscricoes.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext(options)
    {
        public DbSet<MyUser> AppUsers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Registration> Registrations { get; set; }

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MyUser>()
                .HasDiscriminator<string>("UserType")
                .HasValue<Student>("Student")
                .HasValue<Professor>("Professor");

            // Configure the many-to-many relationship between Professor and Course
            modelBuilder.Entity<Professor>()
                .HasMany(p => p.Courses)
                .WithMany(c => c.Professors)
                .UsingEntity(j => j.ToTable("ProfessorCourses"));

            // Configure Degree - Course (One-to-Many)
            modelBuilder.Entity<Course>()
                .HasOne(c => c.Degree)
                .WithMany(d => d.Courses)
                .HasForeignKey(c => c.DegreeId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure Student - Degree (One-to-Many)
            modelBuilder.Entity<Student>()
                .HasOne(s => s.Degree)
                .WithMany(d => d.Students)
                .HasForeignKey(s => s.DegreeId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure Registration (Junction for Student-Course)
            modelBuilder.Entity<Registration>()
                .HasOne(r => r.Student)
                .WithMany(s => s.Registrations)
                .HasForeignKey(r => r.StudentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Registration>()
                .HasOne(r => r.Course)
                .WithMany(c => c.Registrations)
                .HasForeignKey(r => r.CourseId) 
                .OnDelete(DeleteBehavior.Cascade);

            // Prevent duplicate registrations
            modelBuilder.Entity<Registration>()
                .HasIndex(r => new { r.StudentId, r.CourseId })
                .IsUnique();

            // Unique constraints
            modelBuilder.Entity<Student>()
                .HasIndex(s => s.StudentNumber)
                .IsUnique();

            modelBuilder.Entity<MyUser>()
                .HasIndex(u => u.CellPhone)
                .IsUnique();
        }*/
    }
}
