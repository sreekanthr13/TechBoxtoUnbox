using System.ComponentModel.DataAnnotations;

namespace TechBoxtoUnbox.Models.DTO
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; } 
        
        public string CName { get; set; }
        
        public double CFee { get; set; }
        public DateTime Createddate { get; set; }
        public ICollection<StaffCourses> Staffcourses { get; set; }

        public ICollection<StudentCourses> Studentcourses { get; set; }

    }
}
