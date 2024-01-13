using System.ComponentModel.DataAnnotations;

namespace TechBoxtoUnbox.Models.DTO
{
    public class Student
    {
        [Key]
        public int Student_Id { get; set; }
        public int Student_Age { get; set; }
        public string Student_Name { get; set; }
        public string? Student_Email { get; set; }
        public string Student_Phone { get; set; }
        public string? Student_Address { get; set; }
        public bool Student_Gneder { get; set; }
        public bool Student_Qualification { get;}
        public string? Student_Resume { get; set; }
    }
}
