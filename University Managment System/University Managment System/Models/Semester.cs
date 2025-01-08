using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace University_Managment_System
{
    public class Semester
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        public bool IsCurrent { get; set; }

        public ICollection<Course> Courses { get; set; } = [];
        public ICollection<EnrollStudentInCourse> EnrollStudentInCourses { get; set; } = [];
        public ICollection<Student> Students { get; set; } = [];
    }
}