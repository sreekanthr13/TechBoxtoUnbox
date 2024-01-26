using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechBoxtoUnbox.Models.DTO
{
    public class StaffCourses
    {
        [Key]
        public int Stfcrs_Id { get; set; }

        [ForeignKey("staff")]
        public int StaffId { get; set; }

        [ForeignKey("course")]
        public int CourseId { get; set; }

        public Staff staff { get; set; }

        public Course course { get; set; }
    }
}
