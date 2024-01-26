using System.ComponentModel.DataAnnotations;

namespace TechBoxtoUnbox.Models.DTO
{
    public class Staff
    {
        [Key]
        public int St_ID { get; set; }
        public string St_Name { get; set; }
        
        public bool St_Gender { get; set; }
        public string St_Address { get; set; }
        public string St_phone { get; set; }

        public DateTime St_DOJ { get; set; }

        public DateTime? St_DOE { get; set; }

        public ICollection<StaffCourses> Staffcourses { get; set; }
    }
}
