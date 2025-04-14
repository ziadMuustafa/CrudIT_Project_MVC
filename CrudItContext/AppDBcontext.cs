using Microsoft.EntityFrameworkCore;
using CrudIT_Project.Models;
using CrudIT_Project.ViewModels;

namespace CrudIT_Project.CrudItContext
{
    public class AppDBcontext : DbContext
    {
        public AppDBcontext(DbContextOptions<AppDBcontext> options) : base(options)
        {


        }

        //OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //handeling M-M relationship between Trainees and Course
            modelBuilder.Entity<Course>()
                        .HasMany(c => c.Trainees)
                        .WithMany(t => t.Courses)
                        .UsingEntity(j => j.ToTable("TraineeCourse"));



            modelBuilder.Entity<TraineeCourse>()
                        .HasKey(tc => new { tc.CourseId, tc.TraineeId });



        }

        public DbSet<Department> Departments { get; set; }
       public DbSet<Course> Courses { get; set; }
       public DbSet<Instractor> Instractors { get; set; }
       public DbSet<Trainee> Trainees { get; set; }
       public DbSet<TraineeCourse> TraineeCourses { get; set; }   
        public DbSet<CrudIT_Project.ViewModels.CourseDepInstractorcs> CourseDepInstractorcs { get; set; } = default!;

    }
}
