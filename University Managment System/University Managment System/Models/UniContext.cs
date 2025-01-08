using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using University_Managment_System;
public class UniContext : DbContext
{
    public UniContext(DbContextOptions<UniContext> options) : base(options)
    {
    }

    // DbSets for each model
    public DbSet<LectureClassroom> LectureClassrooms { get; set; }
    public DbSet<LectureClassSchedule> LectureClassSchedules { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Faculty> Faculties { get; set; }
    public DbSet<Administrator> Administrators { get; set; }
    public DbSet<Attendance> Attendances { get; set; }
    public DbSet<AcademicGrade> AcademicGrades { get; set; }
    public DbSet<Books> Books { get; set; }
    public DbSet<BookLoans> BookLoans { get; set; }
    public DbSet<Finance> Finances { get; set; }
    public DbSet<Professor> Professors { get; set; }

    public DbSet<Student> Students { get; set; }
    public DbSet<FinalGrade> FinalGrades { get; set; }
    public DbSet<SectionClassSchedule> SectionClassSchedules { get; set; }
    public DbSet<TeachingAssistant> TeachingAssistants { get; set; }
    public DbSet<RegistrationGenerator> RegistrationGenerators { get; set; }
    public DbSet<SectionRoom> SectionRooms { get; set; }
    public DbSet<Semester> Semesters { get; set; }
    public DbSet<Grievance> Grievances { get; set; }
    public DbSet<AcademicRecord> AcademicRecords { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seeding Roles
        modelBuilder.Entity<Role>().HasData(
            new Role { Id = 1, RoleName = "Student" },
            new Role { Id = 2, RoleName = "Professor" },
            new Role { Id = 3, RoleName = "Admin" },
            new Role { Id = 4, RoleName = "TeachingAssistant" }
        );

        // Configure relationships
        modelBuilder.Entity<Student>()
           .HasOne(s => s.AcademicRecord)
           .WithOne(a => a.Student)
           .HasForeignKey<AcademicRecord>(a => a.StudentId);

        modelBuilder.Entity<EnrollStudentInCourse>()
            .HasKey(e => new { e.StudentId, e.CourseId });

        modelBuilder.Entity<EnrollStudentInCourse>()
            .HasOne(e => e.Student)
            .WithMany(s => s.EnrollStudentInCourses)
            .HasForeignKey(e => e.StudentId);

        modelBuilder.Entity<EnrollStudentInCourse>()
            .HasOne(e => e.Course)
            .WithMany(c => c.EnrollStudentInCourses)
            .HasForeignKey(e => e.CourseId);

        modelBuilder.Entity<EnrollStudentInCourse>()
            .HasOne(e => e.Semester)
            .WithMany(s => s.EnrollStudentInCourses)
            .HasForeignKey(e => e.SemesterId);



        modelBuilder.Entity<Course>()
           .HasMany(c => c.TeachingAssistants)
           .WithMany(ta => ta.Courses)
           .UsingEntity(j => j.ToTable("CourseTeachingAssistant"));
        modelBuilder.Entity<Course>()
          .HasMany(c => c.Professors)
          .WithMany(ta => ta.Courses)
          .UsingEntity(j => j.ToTable("Courseprof"));
        // One-to-Many: Administrator manages multiple departments
        modelBuilder.Entity<Administrator>()
            .HasMany(a => a.ManagedDepartments)
            .WithOne(d => d.Administrator)
            .HasForeignKey(d => d.AdministratorId)
            .OnDelete(DeleteBehavior.Restrict); // Disable NoAction delete

        // Many-to-Many: Administrator manages multiple courses
        modelBuilder.Entity<Administrator>()
        .HasMany(a => a.ManagedCourses)
        .WithMany(c => c.Administrators)
        .UsingEntity(j => j.ToTable("AdministratorCourses"));
        modelBuilder.Entity<Student>()
        .HasOne(s => s.Role)
        .WithMany(r => r.Students)
        .HasForeignKey(s => s.RoleId);

        modelBuilder.Entity<Professor>()
            .HasOne(p => p.Role)
            .WithMany(r => r.Professors)
            .HasForeignKey(p => p.RoleId);

        modelBuilder.Entity<TeachingAssistant>()
            .HasOne(ta => ta.Role)
            .WithMany(r => r.TeachingAssistants)
            .HasForeignKey(ta => ta.RoleId);

        modelBuilder.Entity<Administrator>()
            .HasOne(a => a.Role)
            .WithMany(r => r.Administrators)
            .HasForeignKey(a => a.RoleId);

        modelBuilder.Entity<Faculty>()
            .HasOne(f => f.Role)
            .WithMany(r => r.Faculties)
            .HasForeignKey(f => f.RoleId);
    }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.ConfigureWarnings(warnings =>
            warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
    }
}

