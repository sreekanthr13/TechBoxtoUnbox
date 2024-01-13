using System.ComponentModel.DataAnnotations;

namespace TechBoxtoUnbox.Models.DTO
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; } 
        
        public string CName { get; set; }
        
        public decimal CFee { get; set; }
        public DateTime Createddate { get; set; }
    }
}
