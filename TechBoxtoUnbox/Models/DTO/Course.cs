﻿using System.ComponentModel.DataAnnotations;

namespace TechBoxtoUnbox.Models.DTO
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string CName { get; set; }
        [Required]
        public double CFee { get; set; }
        public DateTime Createddate { get; set; }
    }
}
