using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TechBoxtoUnbox.Models.DTO
{
    public class StudentCourses
    {
        [Key]
        public int StdCrs_Id { get; set; }

        [ForeignKey("student")]
        public int Student_Id { get; set; }

        [ForeignKey("course")]
        public int Course_id { get; set; }

        public Student student { get; set; }

        public Course course { get; set; }
    }
}
