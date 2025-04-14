using CrudIT_Project.CrudItContext;
using CrudIT_Project.Reposatories;
using Microsoft.EntityFrameworkCore;
using System;
namespace CrudIT_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();


            builder.Services.AddDbContext<AppDBcontext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("ConnString"));
            });

            builder.Services.AddScoped<ICourseRepo, CourseRepo>();
            builder.Services.AddScoped<IInstractorRepo, InstractorRepo>();
            builder.Services.AddScoped<IDepRepo, DepRepo>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
