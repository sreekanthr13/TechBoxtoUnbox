using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using TechBoxtoUnbox.Models.DTO;

namespace TechBoxtoUnbox.DataAccess
{
    public class CourseContext : DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options) : base(options)
        {
        }

        // DbSet properties for your entities go here
        public DbSet<Course> Courses { get; set; }
        public DbSet<Staff> Staffs { get; set;}
        // Additional DbSet properties if needed
    }

}
